namespace WindowsFormsApplication1
{
    partial class TransferForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.accnmLBL = new System.Windows.Forms.Label();
            this.cnclBTTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.accntnoLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.cnfrmBTTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 20;
            // 
            // accnmLBL
            // 
            this.accnmLBL.AutoSize = true;
            this.accnmLBL.Location = new System.Drawing.Point(204, 89);
            this.accnmLBL.Name = "accnmLBL";
            this.accnmLBL.Size = new System.Drawing.Size(0, 13);
            this.accnmLBL.TabIndex = 19;
            // 
            // cnclBTTN
            // 
            this.cnclBTTN.Location = new System.Drawing.Point(331, 237);
            this.cnclBTTN.Name = "cnclBTTN";
            this.cnclBTTN.Size = new System.Drawing.Size(75, 23);
            this.cnclBTTN.TabIndex = 18;
            this.cnclBTTN.Text = "Cancel";
            this.cnclBTTN.UseVisualStyleBackColor = true;
            this.cnclBTTN.Click += new System.EventHandler(this.cnclBTTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Please Enter The Account Number To Transfer To:";
            // 
            // accntnoLBL
            // 
            this.accntnoLBL.AutoSize = true;
            this.accntnoLBL.Location = new System.Drawing.Point(107, 89);
            this.accntnoLBL.Name = "accntnoLBL";
            this.accntnoLBL.Size = new System.Drawing.Size(90, 13);
            this.accntnoLBL.TabIndex = 16;
            this.accntnoLBL.Text = "Account Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please Enter the desired amount:";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(110, 144);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(401, 20);
            this.amountTB.TabIndex = 14;
            this.amountTB.TextChanged += new System.EventHandler(this.amountTB_TextChanged);
            // 
            // cnfrmBTTN
            // 
            this.cnfrmBTTN.Location = new System.Drawing.Point(195, 237);
            this.cnfrmBTTN.Name = "cnfrmBTTN";
            this.cnfrmBTTN.Size = new System.Drawing.Size(75, 23);
            this.cnfrmBTTN.TabIndex = 13;
            this.cnfrmBTTN.Text = "Confirm";
            this.cnfrmBTTN.UseVisualStyleBackColor = true;
            this.cnfrmBTTN.Click += new System.EventHandler(this.cnfrmBTTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 348);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accnmLBL);
            this.Controls.Add(this.cnclBTTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accntnoLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.cnfrmBTTN);
            this.Name = "TransferForm";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label accnmLBL;
        private System.Windows.Forms.Button cnclBTTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label accntnoLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Button cnfrmBTTN;
        private System.Windows.Forms.TextBox textBox1;
    }
}