using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class ReciptForm : Form
    {
        public ReciptForm()
        {
            InitializeComponent();
        }

        private static ReciptForm defaultInstance;


        public static ReciptForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new ReciptForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        MySqlDataAdapter wkbnchDA = new MySqlDataAdapter();
        MySqlConnection wkbnchCon = new MySqlConnection();
        DataTable wkbnchDTbl = new DataTable();
        string sql;
        MySqlCommand cmd = new MySqlCommand();

        private void ReciptForm_Load(Object sender, EventArgs e)
        {
            wkbnchCon.ConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=toor;database=bankschema;";
            label2.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void okBTTN_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
            }
            else
            {
                wkbnchCon.Open();
                double total = Double.Parse(label7.Text);
                MySqlDataAdapter wkbnchDAA = new MySqlDataAdapter("SELECT * from dataTable", wkbnchCon);
                sql = "UPDATE dataTable SET Balance=\'" + total.ToString() + "\'" + " WHERE FirstName=\'" + label3.Text + "\'";
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
}
