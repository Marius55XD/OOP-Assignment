namespace Invoice_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal1 = Convert.ToDecimal(txtSubtotal.Text);

            decimal DiscountPercent = 0m;

            if (subtotal1 >= 500)
            {
                DiscountPercent = .2m;

            }


            else if (subtotal1 >= 250 && subtotal1 < 500)
            {
                DiscountPercent = .15m;


            }


            else if (subtotal1 >= 100 && subtotal1 < 250)
            {
                DiscountPercent = .1m;
            
            
            
            
            }

             // Comment
            decimal DiscountAmount = subtotal1 * DiscountPercent;
            decimal invoiceTotal = subtotal1 - DiscountAmount;

            txtDiscountPercent.Text = DiscountPercent.ToString("p1");
            txtDiscountAmount.Text = DiscountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();








        }
    }
}