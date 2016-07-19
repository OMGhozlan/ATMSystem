using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class BalanceInqForm : Form
    {
        public BalanceInqForm()
        {
            InitializeComponent();
        }

        private static BalanceInqForm defaultInstance;


        public static BalanceInqForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new BalanceInqForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter wkbnchDA = new MySqlDataAdapter();
        DataSet wkbnchDSet = new DataSet();
        MySqlConnection wkbnchCon = new MySqlConnection();
        string sql;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void amntDLBL_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void amntWLBL_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void blncLBL_Click(object sender, EventArgs e)
        {

        }

        private void crrblncLBL_Click(object sender, EventArgs e)
        {

        }

        private void okBTTN_Click(object sender, EventArgs e)
        {
            {
                if (label4.Text == "")
                {
                }
                else
                {
                    wkbnchCon.Open();
                    double total = Double.Parse(label4.Text);
                    MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM datatable", wkbnchCon);
                    sql = "UPDATE datatable SET balance=\'" + total.ToString() + "\'" + " Where Firstname=\'" + label3.Text + "\'";
                    cmd.CommandText = sql;
                    cmd.Connection = wkbnchCon;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    wkbnchCon.Close();
                }

                if (MessageBox.Show("Do You Want to Continue Your Transactions?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    MainForm.Default.Show();
                }
                else
                {
                    MessageBox.Show("Thank You For Banking With Us");
                    LoginForm.Default.Show();
                }
                this.Close();
            }
        }

        private void accnmLBL_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameLBL_Click(object sender, EventArgs e)
        {

        }

        private void BalanceInqForm_Load(object sender, EventArgs e)
        {
            wkbnchCon.ConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=toor;database=bankschema;";
            label2.Text = DateTime.Now.ToString();
        }
    }
}
