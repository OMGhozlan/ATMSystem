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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private static DepositForm defaultInstance;


        public static DepositForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new DepositForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlConnection con = new MySqlConnection();
        DataSet dset = new DataSet();
        MySqlCommand cmd = new MySqlCommand();
        string balance;
        double balancee;
        double amount;
        double total;

        private void button1_Click(Object sender, EventArgs e)
        {
            string Fullname;
            string sql = default(string);
            DataTable wkbnchDTbl = new DataTable();  
            try
            {
                con.ConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=toor;database=bankschema;";
                sql = "SELECT * FROM datatable where  AccountNum = " + accnmLBL.Text + "";
                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(wkbnchDTbl);
                if (wkbnchDTbl.Rows.Count > 0)
                {
                    Fullname = (wkbnchDTbl.Rows[0]["Firstname"]).ToString();
                    balance = (wkbnchDTbl.Rows[0]["Balance"]).ToString();
                    balancee = Double.Parse(balance);
                    amount = Double.Parse(amountTB.Text);
                    total = balancee + amount;
                    ReciptForm.Default.Show();
                    ReciptForm.Default.label4.Text = balance;
                    ReciptForm.Default.label3.Text = Fullname;
                    ReciptForm.Default.label6.Text = amount.ToString();
                    ReciptForm.Default.label4.Text = balancee.ToString();
                    ReciptForm.Default.label8.Text = accnmLBL.Text;
                    ReciptForm.Default.label7.Text = total.ToString();
                    ReciptForm.Default.label5.Show();
                    ReciptForm.Default.label8.Show();
                    ReciptForm.Default.label5.Show();
                    ReciptForm.Default.label6.Show();
                    ReciptForm.Default.label4.Show();
                    this.Hide();

                }
                else
                {
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please enter your desired amount");
            }
            amountTB.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnclBTTN_Click(object sender, EventArgs e)
        {
            MainForm.Default.Show();
            this.Hide();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            accnmLBL.Text = MainForm.Default.label1.Text;
        }
    }
}
