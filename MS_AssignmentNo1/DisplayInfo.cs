using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


namespace MS_AssignmentNo1
{
    public partial class frmDisplayInfo : Form
    {
        // Creating an instance of ProdInfo class
        private ProdInfo myProduct = new ProdInfo();
        public frmDisplayInfo()
        {
            InitializeComponent();
        }
        // Event handler for the 'Previous' button click
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var form3 = new frmProdInfo(); form3.Show();
            this.Hide();
        }
        // Event handler for the 'Exit' button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Event handler for the 'Save' button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save functionality using SaveFileDialog and StreamWriter
            // Writes the product details into a text file
            // Displays a success message upon saving
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(myProduct.DisplayProductDetails());
                }

                MessageBox.Show("Data saved successfully.", "Save");
            }




        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Create a PrintDocument object.
            PrintDocument printDoc = new PrintDocument();


            //Set the event handler for printing.
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            //Display the PrintDialog to chose a printer.
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Parse the price from the textbox
            if (double.TryParse(txtPrice.Text, out double price))
            {
                string invoiceDetails = $"First Name: {txtFName.Text}\n" +
                                        $"Last Name: {txtLName.Text}\n" +
                                        $"Email: {txtEmail.Text}\n" +
                                        $"Price: {price:C}\n";

                Font printFont = new Font("Arial", 12);
                SolidBrush brush = new SolidBrush(Color.Black);

                RectangleF printArea = e.MarginBounds;

                e.Graphics.DrawString(invoiceDetails, printFont, brush, printArea);

                e.HasMorePages = false;
            }
            else
            {
                MessageBox.Show("Invalid price format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDisplayInfo_Load(object sender, EventArgs e)
        {

        }
        // Event handler for the 'Enter' button click
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Retrieves data from textboxes and assigns it to ProdInfo properties
            myProduct.FirstName = txtFName.Text;
            myProduct.LastName = txtLName.Text;
            myProduct.Email = txtEmail.Text;
            myProduct.ProductName = txtProdName.Text;

            double.TryParse(txtPrice.Text, out double price);
            myProduct.Price = price;

            int.TryParse(txtQuantity.Text, out int quantity);
            myProduct.Quantity = quantity;

            // Display entered data using MessageBox.Show
            MessageBox.Show("Entered Data:\r\n" + myProduct.DisplayProductDetails(), "Entered Data");
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            // Option to clear data
            var result = MessageBox.Show("Do you want to clear the entered data?", "Clear Data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Clear the textboxes
                txtFName.Text = string.Empty;
                txtLName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtProdName.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtQuantity.Text = string.Empty;

                // Clear data in the myProduct instance
                myProduct.ClearData();

                MessageBox.Show("Data cleared successfully.", "Data Cleared");
            }
            // Display cleared data using MessageBox.Show
            MessageBox.Show("Cleared Data:\r\n" + myProduct.DisplayProductDetails(), "Cleared Data");
        }
        // ProdInfo class to store and manage product information
        internal class ProdInfo
        {
            public string FirstName { get; internal set; }
            public string LastName { get; internal set; }
            public string Email { get; internal set; }
            public string ProductName { get; internal set; }
            public double Price { get; internal set; }
            public int Quantity { get; internal set; }



            // Method to clear data in ProdInfo instance
            public void ClearData()
            {
                FirstName = LastName = Email = ProductName = string.Empty;
                Price = Quantity = 0;
            }
            // Method to display product details in a formatted string
            public string DisplayProductDetails()
            {
                // Return a formatted string with product details
                return $"Name: {FirstName} {LastName}\nEmail: {Email}\nProduct Name: {ProductName}\nPrice: ${Price}\nQuantity: {Quantity}";
            }
        }
    }
}