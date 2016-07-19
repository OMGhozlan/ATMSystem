namespace WindowsFormsApplication1
{
    partial class ManagerForm
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
            this.txtbday = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.bttnPermit = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.bttnRestrict = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtlnme = new System.Windows.Forms.TextBox();
            this.txtfnme = new System.Windows.Forms.TextBox();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.lblPIN = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.bttnLoadData = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblhide = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.bttnConfirm = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.bttnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbday
            // 
            this.txtbday.Location = new System.Drawing.Point(179, 298);
            this.txtbday.Name = "txtbday";
            this.txtbday.Size = new System.Drawing.Size(121, 20);
            this.txtbday.TabIndex = 36;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(23, 296);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(117, 20);
            this.lblDOB.TabIndex = 35;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDate.Location = new System.Drawing.Point(176, 346);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 15);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Date";
            // 
            // bttnPermit
            // 
            this.bttnPermit.BackColor = System.Drawing.Color.White;
            this.bttnPermit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPermit.ForeColor = System.Drawing.Color.Black;
            this.bttnPermit.Location = new System.Drawing.Point(121, 390);
            this.bttnPermit.Name = "bttnPermit";
            this.bttnPermit.Size = new System.Drawing.Size(86, 34);
            this.bttnPermit.TabIndex = 3;
            this.bttnPermit.Text = "Permit";
            this.bttnPermit.UseVisualStyleBackColor = false;
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.Color.White;
            this.bttnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnCancel.ForeColor = System.Drawing.Color.Black;
            this.bttnCancel.Location = new System.Drawing.Point(321, 389);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(92, 36);
            this.bttnCancel.TabIndex = 24;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = false;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.White;
            this.bttnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnUpdate.ForeColor = System.Drawing.Color.Black;
            this.bttnUpdate.Location = new System.Drawing.Point(223, 389);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(92, 36);
            this.bttnUpdate.TabIndex = 23;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(179, 259);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(70, 21);
            this.cbGender.TabIndex = 29;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(23, 257);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 20);
            this.lblGender.TabIndex = 28;
            this.lblGender.Text = "Gender:";
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(179, 180);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(178, 20);
            this.txtaddr.TabIndex = 27;
            // 
            // bttnRestrict
            // 
            this.bttnRestrict.BackColor = System.Drawing.Color.White;
            this.bttnRestrict.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnRestrict.ForeColor = System.Drawing.Color.Black;
            this.bttnRestrict.Location = new System.Drawing.Point(15, 392);
            this.bttnRestrict.Name = "bttnRestrict";
            this.bttnRestrict.Size = new System.Drawing.Size(91, 31);
            this.bttnRestrict.TabIndex = 0;
            this.bttnRestrict.Text = "Restrict";
            this.bttnRestrict.UseVisualStyleBackColor = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(20, 217);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(144, 20);
            this.lblNumber.TabIndex = 26;
            this.lblNumber.Text = "Contact Number:";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(179, 217);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(178, 20);
            this.txtcontact.TabIndex = 25;
            // 
            // txtlnme
            // 
            this.txtlnme.Location = new System.Drawing.Point(179, 142);
            this.txtlnme.Name = "txtlnme";
            this.txtlnme.Size = new System.Drawing.Size(178, 20);
            this.txtlnme.TabIndex = 22;
            // 
            // txtfnme
            // 
            this.txtfnme.Location = new System.Drawing.Point(179, 104);
            this.txtfnme.Name = "txtfnme";
            this.txtfnme.Size = new System.Drawing.Size(178, 20);
            this.txtfnme.TabIndex = 21;
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(20, 142);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(100, 20);
            this.lblLN.TabIndex = 20;
            this.lblLN.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 180);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 20);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(20, 104);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(101, 20);
            this.lblFN.TabIndex = 18;
            this.lblFN.Text = "First Name:";
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(179, 65);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(178, 20);
            this.txtPincode.TabIndex = 6;
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIN.Location = new System.Drawing.Point(20, 63);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(90, 20);
            this.lblPIN.TabIndex = 5;
            this.lblPIN.Text = "PIN Code:";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(179, 26);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(178, 20);
            this.txtAcctNo.TabIndex = 3;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(20, 26);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(147, 20);
            this.lblAccNum.TabIndex = 1;
            this.lblAccNum.Text = "Account Number:";
            // 
            // bttnLoadData
            // 
            this.bttnLoadData.BackColor = System.Drawing.Color.White;
            this.bttnLoadData.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnLoadData.ForeColor = System.Drawing.Color.Black;
            this.bttnLoadData.Location = new System.Drawing.Point(462, 198);
            this.bttnLoadData.Name = "bttnLoadData";
            this.bttnLoadData.Size = new System.Drawing.Size(138, 31);
            this.bttnLoadData.TabIndex = 13;
            this.bttnLoadData.Text = "Load All";
            this.bttnLoadData.UseVisualStyleBackColor = false;
            this.bttnLoadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(462, 248);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(503, 201);
            this.DataGridView1.TabIndex = 11;
            // 
            // lblhide
            // 
            this.lblhide.AutoSize = true;
            this.lblhide.Location = new System.Drawing.Point(671, 436);
            this.lblhide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhide.Name = "lblhide";
            this.lblhide.Size = new System.Drawing.Size(0, 13);
            this.lblhide.TabIndex = 12;
            this.lblhide.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(7, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // bttnConfirm
            // 
            this.bttnConfirm.BackColor = System.Drawing.Color.White;
            this.bttnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnConfirm.ForeColor = System.Drawing.Color.Black;
            this.bttnConfirm.Location = new System.Drawing.Point(172, 131);
            this.bttnConfirm.Name = "bttnConfirm";
            this.bttnConfirm.Size = new System.Drawing.Size(138, 31);
            this.bttnConfirm.TabIndex = 5;
            this.bttnConfirm.Text = "Confirm";
            this.bttnConfirm.UseVisualStyleBackColor = false;
            this.bttnConfirm.Click += new System.EventHandler(this.bttnConfirm_Click);
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(113, 59);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(197, 26);
            this.txtlname.TabIndex = 5;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.White;
            this.bttnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnSearch.ForeColor = System.Drawing.Color.Black;
            this.bttnSearch.Location = new System.Drawing.Point(348, 56);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(138, 31);
            this.bttnSearch.TabIndex = 4;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.BackColor = System.Drawing.Color.White;
            this.bttnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnEdit.ForeColor = System.Drawing.Color.Black;
            this.bttnEdit.Location = new System.Drawing.Point(348, 19);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(138, 31);
            this.bttnEdit.TabIndex = 4;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.UseVisualStyleBackColor = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(114, 22);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(196, 26);
            this.txtfname.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblLastName);
            this.GroupBox1.Controls.Add(this.bttnConfirm);
            this.GroupBox1.Controls.Add(this.txtlname);
            this.GroupBox1.Controls.Add(this.bttnSearch);
            this.GroupBox1.Controls.Add(this.bttnEdit);
            this.GroupBox1.Controls.Add(this.txtfname);
            this.GroupBox1.Controls.Add(this.lblFirstName);
            this.GroupBox1.Location = new System.Drawing.Point(462, 18);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(503, 168);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Admin";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(7, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtbday);
            this.GroupBox2.Controls.Add(this.lblDOB);
            this.GroupBox2.Controls.Add(this.lblDate);
            this.GroupBox2.Controls.Add(this.bttnPermit);
            this.GroupBox2.Controls.Add(this.bttnCancel);
            this.GroupBox2.Controls.Add(this.bttnUpdate);
            this.GroupBox2.Controls.Add(this.cbGender);
            this.GroupBox2.Controls.Add(this.lblGender);
            this.GroupBox2.Controls.Add(this.txtaddr);
            this.GroupBox2.Controls.Add(this.bttnRestrict);
            this.GroupBox2.Controls.Add(this.lblNumber);
            this.GroupBox2.Controls.Add(this.txtcontact);
            this.GroupBox2.Controls.Add(this.txtlnme);
            this.GroupBox2.Controls.Add(this.txtfnme);
            this.GroupBox2.Controls.Add(this.lblLN);
            this.GroupBox2.Controls.Add(this.lblAddress);
            this.GroupBox2.Controls.Add(this.lblFN);
            this.GroupBox2.Controls.Add(this.txtPincode);
            this.GroupBox2.Controls.Add(this.lblPIN);
            this.GroupBox2.Controls.Add(this.txtAcctNo);
            this.GroupBox2.Controls.Add(this.lblAccNum);
            this.GroupBox2.Location = new System.Drawing.Point(28, 18);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(419, 431);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Account Information";
            // 
            // bttnLogout
            // 
            this.bttnLogout.BackColor = System.Drawing.Color.White;
            this.bttnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bttnLogout.ForeColor = System.Drawing.Color.Black;
            this.bttnLogout.Location = new System.Drawing.Point(810, 198);
            this.bttnLogout.Name = "bttnLogout";
            this.bttnLogout.Size = new System.Drawing.Size(138, 31);
            this.bttnLogout.TabIndex = 14;
            this.bttnLogout.Text = "Logout";
            this.bttnLogout.UseVisualStyleBackColor = false;
            this.bttnLogout.Click += new System.EventHandler(this.bttnLogout_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 466);
            this.Controls.Add(this.bttnLoadData);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.lblhide);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.bttnLogout);
            this.Name = "ManagerForm";
            this.Text = "Manager Form";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbday;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Button bttnPermit;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnUpdate;
        internal System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtaddr;
        internal System.Windows.Forms.Button bttnRestrict;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtlnme;
        private System.Windows.Forms.TextBox txtfnme;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.Label lblAccNum;
        internal System.Windows.Forms.Button bttnLoadData;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label lblhide;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.Button bttnConfirm;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.Button bttnSearch;
        internal System.Windows.Forms.Button bttnEdit;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button bttnLogout;
    }
}