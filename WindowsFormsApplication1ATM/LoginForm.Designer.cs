namespace WindowsFormsApplication1
{
    partial class LoginForm
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
            this.pinTB = new System.Windows.Forms.TextBox();
            this.wlcmLBL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginBTTN = new System.Windows.Forms.Button();
            this.regBTTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pinTB
            // 
            this.pinTB.Location = new System.Drawing.Point(19, 19);
            this.pinTB.Name = "pinTB";
            this.pinTB.PasswordChar = '*';
            this.pinTB.Size = new System.Drawing.Size(219, 20);
            this.pinTB.TabIndex = 0;
            this.pinTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // wlcmLBL
            // 
            this.wlcmLBL.AutoSize = true;
            this.wlcmLBL.Location = new System.Drawing.Point(48, 19);
            this.wlcmLBL.Name = "wlcmLBL";
            this.wlcmLBL.Size = new System.Drawing.Size(190, 13);
            this.wlcmLBL.TabIndex = 1;
            this.wlcmLBL.Text = "Welcome To Amoor International Bank";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pinTB);
            this.groupBox1.Location = new System.Drawing.Point(15, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Insert Your PIN Code:";
            // 
            // loginBTTN
            // 
            this.loginBTTN.Location = new System.Drawing.Point(51, 184);
            this.loginBTTN.Name = "loginBTTN";
            this.loginBTTN.Size = new System.Drawing.Size(75, 23);
            this.loginBTTN.TabIndex = 3;
            this.loginBTTN.Text = "Login";
            this.loginBTTN.UseVisualStyleBackColor = true;
            this.loginBTTN.Click += new System.EventHandler(this.loginBTTN_Click);
            // 
            // regBTTN
            // 
            this.regBTTN.Location = new System.Drawing.Point(163, 184);
            this.regBTTN.Name = "regBTTN";
            this.regBTTN.Size = new System.Drawing.Size(75, 23);
            this.regBTTN.TabIndex = 4;
            this.regBTTN.Text = "Register";
            this.regBTTN.UseVisualStyleBackColor = true;
            this.regBTTN.Click += new System.EventHandler(this.regBTTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.regBTTN);
            this.Controls.Add(this.loginBTTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wlcmLBL);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pinTB;
        private System.Windows.Forms.Label wlcmLBL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginBTTN;
        private System.Windows.Forms.Button regBTTN;
    }
}