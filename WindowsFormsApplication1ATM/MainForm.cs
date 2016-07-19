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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static MainForm defaultInstance;


        public static MainForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new MainForm();
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void blncBTTN_Click(object sender, EventArgs e)
        {

            string Fullname;
            string sql = default(string);
            DataTable dt = new DataTable();
            try
            {

                wkbnchCon.ConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=toor;database=bankschema;";
                sql = "SELECT * FROM datatable where  AccountNum = " + label1.Text + "";
                cmd.Connection = wkbnchCon;
                cmd.CommandText = sql;
                wkbnchDA.SelectCommand = cmd;
                wkbnchDA.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string balance = default(string);
                    Fullname = (dt.Rows[0]["FirstName"]).ToString();
                    balance = (dt.Rows[0]["Balance"]).ToString();

                    BalanceInqForm.Default.Show();
                    //ReciptForm.Default.label3.Text = lblname.Text;
                    BalanceInqForm.Default.label4.Text = balance;
                    BalanceInqForm.Default.label5.Text = label1.Text;
                    BalanceInqForm.Default.label3.Text = Fullname;
                    //ReciptForm.Default.label4.Hide();
                    //ReciptForm.Default.label3.Hide();
                    //ReciptForm.Default.label5.Hide();
                    //ReciptForm.Default.label6.Hide();
                    //ReciptForm.Default.label7.Hide();
                    //ReciptForm.Default.label2.Hide();
                    this.Hide();
               }
                else
                {
                    MessageBox.Show("The inserted PIN code is invalid");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }		
			
        }

        private void dpstBTTN_Click(object sender, EventArgs e)
        {
            DepositForm.Default.Show();
            this.Hide();
        }

        private void wthdrwBTTN_Click(object sender, EventArgs e)
        {
            WithdrawForm.Default.Show();
            this.Hide();
        }

        private void endsessBTTN_Click(object sender, EventArgs e)
        {
            LoginForm.Default.Show();
            this.Hide();
        }

        private void trnsfrBTTN_Click(object sender, EventArgs e)
        {
            TransferForm.Default.Show();
            this.Hide();
        }
    }
}
