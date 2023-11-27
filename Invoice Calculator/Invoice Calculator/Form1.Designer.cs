namespace Invoice_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblSubtotal = new Label();
            lblDiscountPercent = new Label();
            lblDiscountAmount = new Label();
            lblTotal = new Label();
            txtSubtotal = new TextBox();
            txtDiscountPercent = new TextBox();
            txtDiscountAmount = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 0;
            label1.Text = "Invoice Calculator";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(47, 99);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(72, 21);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblDiscountPercent
            // 
            lblDiscountPercent.AutoSize = true;
            lblDiscountPercent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiscountPercent.Location = new Point(47, 157);
            lblDiscountPercent.Name = "lblDiscountPercent";
            lblDiscountPercent.Size = new Size(133, 21);
            lblDiscountPercent.TabIndex = 2;
            lblDiscountPercent.Text = "Discount Percent";
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiscountAmount.Location = new Point(47, 214);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(134, 21);
            lblDiscountAmount.TabIndex = 3;
            lblDiscountAmount.Text = "Discount amount";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(47, 276);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(215, 97);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 5;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new Point(215, 155);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.Size = new Size(100, 23);
            txtDiscountPercent.TabIndex = 6;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(215, 216);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(100, 23);
            txtDiscountAmount.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(215, 278);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(268, 350);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(106, 39);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(449, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 39);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(lblDiscountAmount);
            Controls.Add(lblDiscountPercent);
            Controls.Add(lblSubtotal);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSubtotal;
        private Label lblDiscountPercent;
        private Label lblDiscountAmount;
        private Label lblTotal;
        private TextBox txtSubtotal;
        private TextBox txtDiscountPercent;
        private TextBox txtDiscountAmount;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
    }
}