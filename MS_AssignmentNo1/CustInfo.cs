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
    public partial class CustInfo : Form
    {
        public CustInfo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var form1 = new frmWelcome(); form1.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
