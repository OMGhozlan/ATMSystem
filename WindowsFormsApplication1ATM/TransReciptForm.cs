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
    public partial class TransReciptForm : Form
    {
        public TransReciptForm()
        {
            InitializeComponent();
        }

        private static TransReciptForm defaultInstance;


        public static TransReciptForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new TransReciptForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        MySqlDataAdapter wkbnchDA  = new MySqlDataAdapter();
        DataTable wkbnchDT = new DataTable();
        string sql2;
        string lqs2;
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection wkbnchCon  = new MySqlConnection();
        MySqlCommand cmda = new MySqlCommand();
        MySqlCommand cmdb = new MySqlCommand();

        private void TransReciptForm_Load(object sender, EventArgs e)
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
                double totala = Double.Parse(label7.Text);
                double totalb = Double.Parse(lblttlb.Text);
                MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM dataTable", wkbnchCon);
                sql2 = "UPDATE dataTable SET balance=\'" + totala.ToString() + "\'" + " WHERE Firstname=\'" + label3.Text + "\'";
                lqs2 = "UPDATE dataTable SET balance=\'" + totalb.ToString() + "\'" + " WHERE Firstname=\'" + lbltrnsfr.Text + "\'";
                cmd.CommandText = sql2;
                cmd.Connection = wkbnchCon;
                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd.ExecuteNonQuery());
                cmd.CommandText = lqs2;
                cmd.Connection = wkbnchCon;
                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd.ExecuteNonQuery());
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
            ReciptForm.Default.Close();
        }
    }
}
