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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }
        // Event handler for the Click event of btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the current form when the btnExit is clicked
            this.Close();
        }
        // Event handler for the Click event of btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Creates an instance of frmCustInfo, shows it, and hides the current form
            var form2 = new frmCustInfo(); form2.Show();
            this.Hide();
        }
    }
}
