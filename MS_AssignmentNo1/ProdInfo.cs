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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var form2 = new frmProdInfo(); form2.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var form4 = new frmDisplayInfo(); form4.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
