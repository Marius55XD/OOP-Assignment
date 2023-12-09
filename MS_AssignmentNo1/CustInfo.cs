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
    public partial class frmCustInfo : Form
    {
        // Declare an instance of the CustDetails class at the class level for wider accessibility
        private readonly CustDetails det = new CustDetails();

        public frmCustInfo()
        {
            InitializeComponent();

            // Set initial properties for the txtName TextBox control
            txtName.Width = 100;
            txtName.Height = 50;
            txtName.BackColor = Color.Red;
            txtName.ForeColor = Color.Black;
            txtName.BorderStyle = BorderStyle.Fixed3D;
            txtName.MaxLength = 20;
            txtName.Multiline = false;

            // Attach event handler for the TextChanged event of txtName
            txtName.TextChanged += txtName_TextChanged;
        }

        // Event handler for the Click event of btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close and hide the current form
            this.Close();
            this.Hide();
        }

        // Event handler for the Click event of btnPrevious
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Create an instance of frmWelcome, show it, and hide the current form
            var form1 = new frmWelcome();
            form1.Show();
            this.Hide();
        }

        // Event handler for the Click event of btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Create an instance of frmProdInfo, show it, and hide the current form
            var form3 = new frmProdInfo();
            form3.Show();
            this.Hide();
        }

        // Event handler for the Click event of btnCustInputDetails
        private void btnCustInputDetails_Click(object sender, EventArgs e)
        {
            // Retrieve text input from TextBox controls
            string varName = txtName.Text;
            string varAdd1 = txtAdd1.Text;
            string varAdd2 = txtAdd2.Text;
            string varCounty = txtCounty.Text;
            string varEmail = txtEmail.Text;

           

            // Set customer details using the variables
            det.name = varName;
            det.add1 = varAdd1;
            det.add2 = varAdd2;
            det.county = varCounty;
            det.email = varEmail;

            // Call methods to process customer information
            det.Custinfo();
            det.infoCustAdd();
            det.InfoCusContact();
        }

        // Event handler for the TextChanged event of txtName
        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        // Event handler for the Click event of btnDisCustDetails
        private void btnDisCustDetails_Click(object sender, EventArgs e)
        {
            // Access the CustDetails instance to display all customer details
            det.DisplayAllInfo();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            // No code inside this event handler
        }

        private void frmCustInfo_Load(object sender, EventArgs e)
        {
            // No code inside this event handler
        }
    }
}
