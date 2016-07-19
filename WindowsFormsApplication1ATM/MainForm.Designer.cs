namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endsessBTTN = new System.Windows.Forms.Button();
            this.wthdrwBTTN = new System.Windows.Forms.Button();
            this.dpstBTTN = new System.Windows.Forms.Button();
            this.blncBTTN = new System.Windows.Forms.Button();
            this.trnsfrBTTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accntnmLBL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endsessBTTN);
            this.groupBox1.Controls.Add(this.wthdrwBTTN);
            this.groupBox1.Controls.Add(this.dpstBTTN);
            this.groupBox1.Controls.Add(this.blncBTTN);
            this.groupBox1.Controls.Add(this.trnsfrBTTN);
            this.groupBox1.Location = new System.Drawing.Point(13, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // endsessBTTN
            // 
            this.endsessBTTN.Location = new System.Drawing.Point(143, 86);
            this.endsessBTTN.Name = "endsessBTTN";
            this.endsessBTTN.Size = new System.Drawing.Size(75, 41);
            this.endsessBTTN.TabIndex = 7;
            this.endsessBTTN.Text = "End Session";
            this.endsessBTTN.UseVisualStyleBackColor = true;
            this.endsessBTTN.Click += new System.EventHandler(this.endsessBTTN_Click);
            // 
            // wthdrwBTTN
            // 
            this.wthdrwBTTN.Location = new System.Drawing.Point(245, 135);
            this.wthdrwBTTN.Name = "wthdrwBTTN";
            this.wthdrwBTTN.Size = new System.Drawing.Size(94, 53);
            this.wthdrwBTTN.TabIndex = 6;
            this.wthdrwBTTN.Text = "Withdraw";
            this.wthdrwBTTN.UseVisualStyleBackColor = true;
            this.wthdrwBTTN.Click += new System.EventHandler(this.wthdrwBTTN_Click);
            // 
            // dpstBTTN
            // 
            this.dpstBTTN.Location = new System.Drawing.Point(245, 34);
            this.dpstBTTN.Name = "dpstBTTN";
            this.dpstBTTN.Size = new System.Drawing.Size(94, 53);
            this.dpstBTTN.TabIndex = 5;
            this.dpstBTTN.Text = "Deposit";
            this.dpstBTTN.UseVisualStyleBackColor = true;
            this.dpstBTTN.Click += new System.EventHandler(this.dpstBTTN_Click);
            // 
            // blncBTTN
            // 
            this.blncBTTN.Location = new System.Drawing.Point(31, 34);
            this.blncBTTN.Name = "blncBTTN";
            this.blncBTTN.Size = new System.Drawing.Size(94, 53);
            this.blncBTTN.TabIndex = 4;
            this.blncBTTN.Text = "Balance Inquiry";
            this.blncBTTN.UseVisualStyleBackColor = true;
            this.blncBTTN.Click += new System.EventHandler(this.blncBTTN_Click);
            // 
            // trnsfrBTTN
            // 
            this.trnsfrBTTN.Location = new System.Drawing.Point(31, 135);
            this.trnsfrBTTN.Name = "trnsfrBTTN";
            this.trnsfrBTTN.Size = new System.Drawing.Size(94, 53);
            this.trnsfrBTTN.TabIndex = 3;
            this.trnsfrBTTN.Text = "Transfer";
            this.trnsfrBTTN.UseVisualStyleBackColor = true;
            this.trnsfrBTTN.Click += new System.EventHandler(this.trnsfrBTTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // accntnmLBL
            // 
            this.accntnmLBL.AutoSize = true;
            this.accntnmLBL.Location = new System.Drawing.Point(12, 34);
            this.accntnmLBL.Name = "accntnmLBL";
            this.accntnmLBL.Size = new System.Drawing.Size(90, 13);
            this.accntnmLBL.TabIndex = 2;
            this.accntnmLBL.Text = "Account Number:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 336);
            this.Controls.Add(this.accntnmLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button wthdrwBTTN;
        private System.Windows.Forms.Button dpstBTTN;
        private System.Windows.Forms.Button blncBTTN;
        private System.Windows.Forms.Button trnsfrBTTN;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label accntnmLBL;
        private System.Windows.Forms.Button endsessBTTN;
    }
}