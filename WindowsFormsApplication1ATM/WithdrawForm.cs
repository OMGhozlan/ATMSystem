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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }
        private static WithdrawForm defaultInstance;


        public static WithdrawForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new WithdrawForm();
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
        DataSet wkbnchDSet  = new DataSet();
        MySqlCommand cmd = new MySqlCommand();
        string balance;
        double balancee;
        double amount;
        double total;

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            accnmLBL.Text = MainForm.Default.label1.Text;
        }

        private void cnclBTTN_Click(object sender, EventArgs e)
        {
            MainForm.Default.Show();
            this.Hide();
        }

        private void cnfrmBTTN_Click(object sender, EventArgs e)
        {
            string Fullname;
            string sql = default(string);
            DataTable dt = new DataTable();
            try
            {
                wkbnchCon.ConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=toor;database=bankschema;";
                sql = "SELECT * FROM dataTable where  AccountNum = " + accnmLBL.Text + "";
                cmd.Connection = wkbnchCon;
                cmd.CommandText = sql;
                wkbnchDA.SelectCommand = cmd;
                wkbnchDA.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Fullname = (dt.Rows[0]["Firstname"]).ToString();
                    balance = (dt.Rows[0]["balance"]).ToString();
                    balancee = Double.Parse(balance);
                    amount = Double.Parse(amountTB.Text);
                    if (amount > 5000)
                    {
                        MessageBox.Show("The desired amount exceeds the withdrawal limit");
                        MessageBox.Show("Please enter a valid amount");
                    }
                    else if (balancee < amount)
                    {
                        MessageBox.Show("Insuffiecient balance");

                    }
                    else
                    {
                        total = balancee - amount;
                        ReciptForm.Default.Show();
                        ReciptForm.Default.label4.Text = balance;
                        ReciptForm.Default.label3.Text = Fullname;
                        ReciptForm.Default.label5.Text = amount.ToString();
                        ReciptForm.Default.label4.Text = balancee.ToString();
                        ReciptForm.Default.label8.Text = accnmLBL.Text;
                        ReciptForm.Default.label7.Text = total.ToString();
                        ReciptForm.Default.label5.Show();
                        ReciptForm.Default.label8.Show();
                        ReciptForm.Default.label6.Show();
                        ReciptForm.Default.label4.Show();
                        ReciptForm.Default.label6.Show();
                        this.Hide();
                    }

                }
                else
                {


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter your desired amount");
            }
            amountTB.Text = "";
        }

        private void amountTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
