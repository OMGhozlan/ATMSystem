namespace WindowsFormsApplication1
{
    partial class BalanceInqForm
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
            this.nameLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blncLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okBTTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.accnmLBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Location = new System.Drawing.Point(14, 79);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(38, 13);
            this.nameLBL.TabIndex = 15;
            this.nameLBL.Text = "Name:";
            this.nameLBL.Click += new System.EventHandler(this.nameLBL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 22;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // blncLBL
            // 
            this.blncLBL.AutoSize = true;
            this.blncLBL.Location = new System.Drawing.Point(14, 112);
            this.blncLBL.Name = "blncLBL";
            this.blncLBL.Size = new System.Drawing.Size(46, 13);
            this.blncLBL.TabIndex = 16;
            this.blncLBL.Text = "Balance";
            this.blncLBL.Click += new System.EventHandler(this.blncLBL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thank you for banking with us!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // okBTTN
            // 
            this.okBTTN.Location = new System.Drawing.Point(118, 286);
            this.okBTTN.Name = "okBTTN";
            this.okBTTN.Size = new System.Drawing.Size(75, 23);
            this.okBTTN.TabIndex = 29;
            this.okBTTN.Text = "Confirm";
            this.okBTTN.UseVisualStyleBackColor = true;
            this.okBTTN.Click += new System.EventHandler(this.okBTTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 23;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // accnmLBL
            // 
            this.accnmLBL.AutoSize = true;
            this.accnmLBL.Location = new System.Drawing.Point(14, 149);
            this.accnmLBL.Name = "accnmLBL";
            this.accnmLBL.Size = new System.Drawing.Size(90, 13);
            this.accnmLBL.TabIndex = 27;
            this.accnmLBL.Text = "Account Number:";
            this.accnmLBL.Click += new System.EventHandler(this.accnmLBL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 30;
            // 
            // Bal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 331);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.okBTTN);
            this.Controls.Add(this.accnmLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blncLBL);
            this.Controls.Add(this.nameLBL);
            this.Name = "Bal";
            this.Text = "Balance Inquiry";
            this.Load += new System.EventHandler(this.BalanceInqForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLBL;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label blncLBL;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBTTN;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label accnmLBL;
        public System.Windows.Forms.Label label5;
    }
}