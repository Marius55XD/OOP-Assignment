using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_AssignmentNo1
{
    public partial class frmProdInfo : Form
    {
        public frmProdInfo()
        {
            InitializeComponent();
        }

        // Event handler for the Click event of btnPrevious
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Create an instance of frmCustInfo, show it, and hide the current form
            var form2 = new frmCustInfo();
            form2.Show();
            this.Hide();
        }

        // Event handler for the Click event of btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Create an instance of frmDisplayInfo, show it, and hide the current form
            var form4 = new frmDisplayInfo();
            form4.Show();
            this.Hide();
        }

        // Event handler for the Click event of btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        // Event handler for the Click event of btnCal (Calculate)
        private void btnCal_Click(object sender, EventArgs e)
        {
            // Validate the subtotal input
            if (!decimal.TryParse(txtTotAmount.Text, out decimal subtotal) || subtotal <= 0)
            {
                // Show error message for invalid input and exit the method
                MessageBox.Show("Invalid input. Please enter the total amount for the products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get product details from the user input
            string productName = txtProdName.Text;
            double productPrice = Convert.ToDouble(txtPrice.Text);
            int productStock = Convert.ToInt32(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            // Calculate total amount
            double totalAmount = productPrice * quantity;

            // Determine discount percentage based on total amount
            double discountPercentage = 0;

            if (totalAmount >= 1500)
            {
                discountPercentage = 20;
            }
            else if (totalAmount > 500 && totalAmount < 1500)
            {
                discountPercentage = 15;
            }
            else if (totalAmount > 200 && totalAmount <= 500)
            {
                discountPercentage = 10;
            }
            // 0% discount for amounts less than 200 euro (no need to explicitly check, as discountPercentage is already initialized to 0)

            // Calculate discount amount
            double discountAmount = (discountPercentage / 100) * totalAmount;

            // Calculate final amount after discount
            double finalAmount = totalAmount - discountAmount;

            // Prepare a message with calculated results
            string resultMessage = $"Product Details:\r\nName: {productName}\r\nPrice: {productPrice} euro\r\nStock: {productStock}\r\nQuantity: {quantity}\r\nTotal Amount: {totalAmount} euro\r\nDiscount Percentage: {discountPercentage}%\r\nDiscount Amount: {discountAmount} euro\r\nFinal Amount after Discount: {finalAmount} euro";

            // Display calculated results in a message box
            MessageBox.Show(resultMessage, "Calculation Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for the TextChanged event of txtFinAmount
        private void txtFinAmount_TextChanged(object sender, EventArgs e)
        {
            // No code inside this event handler
        }

        // Event handler for the Click event of lblTotAmount (Total Amount label)
        private void lblTotAmount_Click(object sender, EventArgs e)
        {
            // No code inside this event handler
        }
    }
}
