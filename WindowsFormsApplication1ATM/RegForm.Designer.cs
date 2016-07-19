namespace WindowsFormsApplication1
{
    partial class RegForm
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
            this.pinLBL = new System.Windows.Forms.Label();
            this.fstnameLBL = new System.Windows.Forms.Label();
            this.mddlnameLBL = new System.Windows.Forms.Label();
            this.lstnameLBL = new System.Windows.Forms.Label();
            this.addrsLBL = new System.Windows.Forms.Label();
            this.phnLBL = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.gndrLBL = new System.Windows.Forms.Label();
            this.dobLBL = new System.Windows.Forms.Label();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.regBTTN = new System.Windows.Forms.Button();
            this.cnclBTTN = new System.Windows.Forms.Button();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.phnTB = new System.Windows.Forms.TextBox();
            this.addrsTB = new System.Windows.Forms.TextBox();
            this.lstnmTB = new System.Windows.Forms.TextBox();
            this.mddlnmTB = new System.Windows.Forms.TextBox();
            this.fstnmTB = new System.Windows.Forms.TextBox();
            this.pinTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pinLBL
            // 
            this.pinLBL.AutoSize = true;
            this.pinLBL.Location = new System.Drawing.Point(12, 39);
            this.pinLBL.Name = "pinLBL";
            this.pinLBL.Size = new System.Drawing.Size(56, 13);
            this.pinLBL.TabIndex = 1;
            this.pinLBL.Text = "PIN Code:";
            // 
            // fstnameLBL
            // 
            this.fstnameLBL.AutoSize = true;
            this.fstnameLBL.Location = new System.Drawing.Point(12, 72);
            this.fstnameLBL.Name = "fstnameLBL";
            this.fstnameLBL.Size = new System.Drawing.Size(60, 13);
            this.fstnameLBL.TabIndex = 2;
            this.fstnameLBL.Text = "First Name:";
            // 
            // mddlnameLBL
            // 
            this.mddlnameLBL.AutoSize = true;
            this.mddlnameLBL.Location = new System.Drawing.Point(13, 112);
            this.mddlnameLBL.Name = "mddlnameLBL";
            this.mddlnameLBL.Size = new System.Drawing.Size(72, 13);
            this.mddlnameLBL.TabIndex = 3;
            this.mddlnameLBL.Text = "Middle Name:";
            // 
            // lstnameLBL
            // 
            this.lstnameLBL.AutoSize = true;
            this.lstnameLBL.Location = new System.Drawing.Point(12, 146);
            this.lstnameLBL.Name = "lstnameLBL";
            this.lstnameLBL.Size = new System.Drawing.Size(61, 13);
            this.lstnameLBL.TabIndex = 4;
            this.lstnameLBL.Text = "Last Name:";
            this.lstnameLBL.Click += new System.EventHandler(this.label5_Click);
            // 
            // addrsLBL
            // 
            this.addrsLBL.AutoSize = true;
            this.addrsLBL.Location = new System.Drawing.Point(13, 172);
            this.addrsLBL.Name = "addrsLBL";
            this.addrsLBL.Size = new System.Drawing.Size(48, 13);
            this.addrsLBL.TabIndex = 5;
            this.addrsLBL.Text = "Address:";
            this.addrsLBL.Click += new System.EventHandler(this.label6_Click);
            // 
            // phnLBL
            // 
            this.phnLBL.AutoSize = true;
            this.phnLBL.Location = new System.Drawing.Point(13, 203);
            this.phnLBL.Name = "phnLBL";
            this.phnLBL.Size = new System.Drawing.Size(77, 13);
            this.phnLBL.TabIndex = 6;
            this.phnLBL.Text = "Phone/Mobile:";
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCB.Location = new System.Drawing.Point(99, 243);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(88, 21);
            this.genderCB.TabIndex = 7;
            // 
            // gndrLBL
            // 
            this.gndrLBL.AutoSize = true;
            this.gndrLBL.Location = new System.Drawing.Point(13, 246);
            this.gndrLBL.Name = "gndrLBL";
            this.gndrLBL.Size = new System.Drawing.Size(45, 13);
            this.gndrLBL.TabIndex = 8;
            this.gndrLBL.Text = "Gender:";
            // 
            // dobLBL
            // 
            this.dobLBL.AutoSize = true;
            this.dobLBL.Location = new System.Drawing.Point(16, 285);
            this.dobLBL.Name = "dobLBL";
            this.dobLBL.Size = new System.Drawing.Size(66, 13);
            this.dobLBL.TabIndex = 9;
            this.dobLBL.Text = "Date of Birth";
            // 
            // dayCB
            // 
            this.dayCB.FormattingEnabled = true;
            this.dayCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayCB.Location = new System.Drawing.Point(99, 282);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(58, 21);
            this.dayCB.TabIndex = 10;
            this.dayCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // regBTTN
            // 
            this.regBTTN.Location = new System.Drawing.Point(138, 339);
            this.regBTTN.Name = "regBTTN";
            this.regBTTN.Size = new System.Drawing.Size(75, 23);
            this.regBTTN.TabIndex = 13;
            this.regBTTN.Text = "Register";
            this.regBTTN.UseVisualStyleBackColor = true;
            this.regBTTN.Click += new System.EventHandler(this.regBTTN_Click);
            // 
            // cnclBTTN
            // 
            this.cnclBTTN.Location = new System.Drawing.Point(255, 339);
            this.cnclBTTN.Name = "cnclBTTN";
            this.cnclBTTN.Size = new System.Drawing.Size(75, 23);
            this.cnclBTTN.TabIndex = 14;
            this.cnclBTTN.Text = "Cancel";
            this.cnclBTTN.UseVisualStyleBackColor = true;
            this.cnclBTTN.Click += new System.EventHandler(this.cnclBTTN_Click);
            // 
            // monthCB
            // 
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthCB.Location = new System.Drawing.Point(173, 282);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(58, 21);
            this.monthCB.TabIndex = 15;
            // 
            // yearCB
            // 
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Items.AddRange(new object[] {
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930"});
            this.yearCB.Location = new System.Drawing.Point(246, 282);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(58, 21);
            this.yearCB.TabIndex = 16;
            this.yearCB.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // phnTB
            // 
            this.phnTB.Location = new System.Drawing.Point(99, 203);
            this.phnTB.Name = "phnTB";
            this.phnTB.Size = new System.Drawing.Size(338, 20);
            this.phnTB.TabIndex = 17;
            // 
            // addrsTB
            // 
            this.addrsTB.Location = new System.Drawing.Point(99, 169);
            this.addrsTB.Name = "addrsTB";
            this.addrsTB.Size = new System.Drawing.Size(338, 20);
            this.addrsTB.TabIndex = 18;
            // 
            // lstnmTB
            // 
            this.lstnmTB.Location = new System.Drawing.Point(99, 139);
            this.lstnmTB.Name = "lstnmTB";
            this.lstnmTB.Size = new System.Drawing.Size(338, 20);
            this.lstnmTB.TabIndex = 19;
            // 
            // mddlnmTB
            // 
            this.mddlnmTB.Location = new System.Drawing.Point(99, 109);
            this.mddlnmTB.Name = "mddlnmTB";
            this.mddlnmTB.Size = new System.Drawing.Size(338, 20);
            this.mddlnmTB.TabIndex = 20;
            // 
            // fstnmTB
            // 
            this.fstnmTB.Location = new System.Drawing.Point(99, 72);
            this.fstnmTB.Name = "fstnmTB";
            this.fstnmTB.Size = new System.Drawing.Size(338, 20);
            this.fstnmTB.TabIndex = 21;
            // 
            // pinTB
            // 
            this.pinTB.Location = new System.Drawing.Point(99, 39);
            this.pinTB.Name = "pinTB";
            this.pinTB.Size = new System.Drawing.Size(338, 20);
            this.pinTB.TabIndex = 22;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(525, 374);
            this.Controls.Add(this.pinTB);
            this.Controls.Add(this.fstnmTB);
            this.Controls.Add(this.mddlnmTB);
            this.Controls.Add(this.lstnmTB);
            this.Controls.Add(this.addrsTB);
            this.Controls.Add(this.phnTB);
            this.Controls.Add(this.yearCB);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.cnclBTTN);
            this.Controls.Add(this.regBTTN);
            this.Controls.Add(this.dayCB);
            this.Controls.Add(this.dobLBL);
            this.Controls.Add(this.gndrLBL);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.phnLBL);
            this.Controls.Add(this.addrsLBL);
            this.Controls.Add(this.lstnameLBL);
            this.Controls.Add(this.mddlnameLBL);
            this.Controls.Add(this.fstnameLBL);
            this.Controls.Add(this.pinLBL);
            this.Name = "RegForm";
            this.Text = "Registeration";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pinLBL;
        private System.Windows.Forms.Label fstnameLBL;
        private System.Windows.Forms.Label mddlnameLBL;
        private System.Windows.Forms.Label lstnameLBL;
        private System.Windows.Forms.Label addrsLBL;
        private System.Windows.Forms.Label phnLBL;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Label gndrLBL;
        private System.Windows.Forms.Label dobLBL;
        private System.Windows.Forms.ComboBox dayCB;
        private System.Windows.Forms.Button regBTTN;
        private System.Windows.Forms.Button cnclBTTN;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.TextBox phnTB;
        private System.Windows.Forms.TextBox addrsTB;
        private System.Windows.Forms.TextBox lstnmTB;
        private System.Windows.Forms.TextBox mddlnmTB;
        private System.Windows.Forms.TextBox fstnmTB;
        private System.Windows.Forms.TextBox pinTB;
    }
}