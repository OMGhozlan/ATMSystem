namespace WindowsFormsApplication1
{
    partial class DepositForm
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
            this.cnfrmBTTN = new System.Windows.Forms.Button();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accntnoLBL = new System.Windows.Forms.Label();
            this.cnclBTTN = new System.Windows.Forms.Button();
            this.accnmLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cnfrmBTTN
            // 
            this.cnfrmBTTN.Location = new System.Drawing.Point(130, 183);
            this.cnfrmBTTN.Name = "cnfrmBTTN";
            this.cnfrmBTTN.Size = new System.Drawing.Size(75, 23);
            this.cnfrmBTTN.TabIndex = 0;
            this.cnfrmBTTN.Text = "Confirm";
            this.cnfrmBTTN.UseVisualStyleBackColor = true;
            this.cnfrmBTTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(60, 125);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(401, 20);
            this.amountTB.TabIndex = 1;
            this.amountTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter the desired amount:";
            // 
            // accntnoLBL
            // 
            this.accntnoLBL.AutoSize = true;
            this.accntnoLBL.Location = new System.Drawing.Point(57, 42);
            this.accntnoLBL.Name = "accntnoLBL";
            this.accntnoLBL.Size = new System.Drawing.Size(90, 13);
            this.accntnoLBL.TabIndex = 3;
            this.accntnoLBL.Text = "Account Number:";
            // 
            // cnclBTTN
            // 
            this.cnclBTTN.Location = new System.Drawing.Point(283, 183);
            this.cnclBTTN.Name = "cnclBTTN";
            this.cnclBTTN.Size = new System.Drawing.Size(75, 23);
            this.cnclBTTN.TabIndex = 4;
            this.cnclBTTN.Text = "Cancel";
            this.cnclBTTN.UseVisualStyleBackColor = true;
            this.cnclBTTN.Click += new System.EventHandler(this.cnclBTTN_Click);
            // 
            // accnmLBL
            // 
            this.accnmLBL.AutoSize = true;
            this.accnmLBL.Location = new System.Drawing.Point(153, 42);
            this.accnmLBL.Name = "accnmLBL";
            this.accnmLBL.Size = new System.Drawing.Size(0, 13);
            this.accnmLBL.TabIndex = 5;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 290);
            this.Controls.Add(this.accnmLBL);
            this.Controls.Add(this.cnclBTTN);
            this.Controls.Add(this.accntnoLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.cnfrmBTTN);
            this.Name = "DepositForm";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cnfrmBTTN;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accntnoLBL;
        private System.Windows.Forms.Button cnclBTTN;
        private System.Windows.Forms.Label accnmLBL;
    }
}