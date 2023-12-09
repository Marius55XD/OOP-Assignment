namespace MS_AssignmentNo1
{
    partial class frmProdInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProdInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblDisPercentage = new System.Windows.Forms.Label();
            this.lblDisAmount = new System.Windows.Forms.Label();
            this.lblFinAmount = new System.Windows.Forms.Label();
            this.lblTotAmount = new System.Windows.Forms.Label();
            this.txtDisPercent = new System.Windows.Forms.TextBox();
            this.txtDisAmount = new System.Windows.Forms.TextBox();
            this.txtFinAmount = new System.Windows.Forms.TextBox();
            this.txtTotAmount = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProdInfo
            // 
            this.lblProdInfo.AutoSize = true;
            this.lblProdInfo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdInfo.Location = new System.Drawing.Point(265, 42);
            this.lblProdInfo.Name = "lblProdInfo";
            this.lblProdInfo.Size = new System.Drawing.Size(301, 31);
            this.lblProdInfo.TabIndex = 8;
            this.lblProdInfo.Text = "Product Information";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrevious.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(559, 394);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(101, 33);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<< Previous ";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNext.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(687, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 33);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(31, 125);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(148, 21);
            this.lblProdName.TabIndex = 12;
            this.lblProdName.Text = "Product Name";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(204, 122);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(133, 26);
            this.txtProdName.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(31, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 21);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(144, 180);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(133, 26);
            this.txtPrice.TabIndex = 15;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(31, 232);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(66, 21);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(144, 227);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(133, 26);
            this.txtStock.TabIndex = 17;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(31, 280);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(99, 21);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(162, 280);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(133, 26);
            this.txtQuantity.TabIndex = 19;
            // 
            // lblDisPercentage
            // 
            this.lblDisPercentage.AutoSize = true;
            this.lblDisPercentage.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisPercentage.Location = new System.Drawing.Point(391, 123);
            this.lblDisPercentage.Name = "lblDisPercentage";
            this.lblDisPercentage.Size = new System.Drawing.Size(209, 21);
            this.lblDisPercentage.TabIndex = 20;
            this.lblDisPercentage.Text = "Discount Percentage";
            // 
            // lblDisAmount
            // 
            this.lblDisAmount.AutoSize = true;
            this.lblDisAmount.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisAmount.Location = new System.Drawing.Point(391, 180);
            this.lblDisAmount.Name = "lblDisAmount";
            this.lblDisAmount.Size = new System.Drawing.Size(182, 21);
            this.lblDisAmount.TabIndex = 21;
            this.lblDisAmount.Text = "Discount Amount";
            // 
            // lblFinAmount
            // 
            this.lblFinAmount.AutoSize = true;
            this.lblFinAmount.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinAmount.Location = new System.Drawing.Point(391, 285);
            this.lblFinAmount.Name = "lblFinAmount";
            this.lblFinAmount.Size = new System.Drawing.Size(146, 21);
            this.lblFinAmount.TabIndex = 22;
            this.lblFinAmount.Text = "Final Amount";
            // 
            // lblTotAmount
            // 
            this.lblTotAmount.AutoSize = true;
            this.lblTotAmount.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAmount.Location = new System.Drawing.Point(391, 232);
            this.lblTotAmount.Name = "lblTotAmount";
            this.lblTotAmount.Size = new System.Drawing.Size(146, 21);
            this.lblTotAmount.TabIndex = 23;
            this.lblTotAmount.Text = "Total Amount";
            this.lblTotAmount.Click += new System.EventHandler(this.lblTotAmount_Click);
            // 
            // txtDisPercent
            // 
            this.txtDisPercent.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisPercent.Location = new System.Drawing.Point(627, 118);
            this.txtDisPercent.Name = "txtDisPercent";
            this.txtDisPercent.Size = new System.Drawing.Size(133, 26);
            this.txtDisPercent.TabIndex = 24;
            // 
            // txtDisAmount
            // 
            this.txtDisAmount.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisAmount.Location = new System.Drawing.Point(627, 181);
            this.txtDisAmount.Name = "txtDisAmount";
            this.txtDisAmount.Size = new System.Drawing.Size(133, 26);
            this.txtDisAmount.TabIndex = 25;
            // 
            // txtFinAmount
            // 
            this.txtFinAmount.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinAmount.Location = new System.Drawing.Point(588, 285);
            this.txtFinAmount.Name = "txtFinAmount";
            this.txtFinAmount.Size = new System.Drawing.Size(133, 26);
            this.txtFinAmount.TabIndex = 26;
            this.txtFinAmount.TextChanged += new System.EventHandler(this.txtFinAmount_TextChanged);
            // 
            // txtTotAmount
            // 
            this.txtTotAmount.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotAmount.Location = new System.Drawing.Point(588, 232);
            this.txtTotAmount.Name = "txtTotAmount";
            this.txtTotAmount.Size = new System.Drawing.Size(133, 26);
            this.txtTotAmount.TabIndex = 27;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Yellow;
            this.btnCal.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(309, 337);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(119, 48);
            this.btnCal.TabIndex = 28;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // frmProdInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MS_AssignmentNo1.Properties.Resources.Murphysltdlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtTotAmount);
            this.Controls.Add(this.txtFinAmount);
            this.Controls.Add(this.txtDisAmount);
            this.Controls.Add(this.txtDisPercent);
            this.Controls.Add(this.lblTotAmount);
            this.Controls.Add(this.lblFinAmount);
            this.Controls.Add(this.lblDisAmount);
            this.Controls.Add(this.lblDisPercentage);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblProdInfo);
            this.DoubleBuffered = true;
            this.Name = "frmProdInfo";
            this.Text = "ProdInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblDisPercentage;
        private System.Windows.Forms.Label lblDisAmount;
        private System.Windows.Forms.Label lblFinAmount;
        private System.Windows.Forms.Label lblTotAmount;
        private System.Windows.Forms.TextBox txtDisPercent;
        private System.Windows.Forms.TextBox txtDisAmount;
        private System.Windows.Forms.TextBox txtFinAmount;
        private System.Windows.Forms.TextBox txtTotAmount;
        private System.Windows.Forms.Button btnCal;
    }
}