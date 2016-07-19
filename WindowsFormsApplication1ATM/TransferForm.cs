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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private static TransferForm defaultInstance;


        public static TransferForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new TransferForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(Object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        string Fullname;
        string Fullnamee;
        string sql = default(string);
        string lqs = default(string);
        DataTable wkbnchDTbla = new DataTable();
        DataTable wkbnchDTblb = new DataTable();
        MySqlDataAdapter wkbnchDAa = new MySqlDataAdapter();
        MySqlDataAdapter wkbnchDAb = new MySqlDataAdapter();
        MySqlConnection wkbnchCon = new MySqlConnection();
        DataSet wkbnchDSet = new DataSet();
        MySqlCommand cmda = new MySqlCommand();
        MySqlCommand cmdb = new MySqlCommand();
        string balance;
        double balancea;
        double balanceb;
        double amount;
        double total;
        public double totala;
        public double totalb;

        private void TransferForm_Load(Object sender, EventArgs e)
        {
            accnmLBL.Text = MainForm.Default.label1.Text;
        }

        private void cnfrmBTTN_Click(Object sender, EventArgs e)
        {

            try
            {
                wkbnchCon.ConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=toor;database=bankschema;";
                sql = "SELECT * FROM dataTable WHERE  AccountNum = " + accnmLBL.Text + "";
                cmda.Connection = wkbnchCon;
                cmda.CommandText = sql;
                wkbnchDAa.SelectCommand = cmda;
                wkbnchDAa.Fill(wkbnchDTbla);
                if (wkbnchDTbla.Rows.Count > 0)
                {
                    Fullnamee = (wkbnchDTbla.Rows[0]["FirstName"]).ToString();
                    balance = (wkbnchDTbla.Rows[0]["Balance"]).ToString();
                    balancea = Double.Parse(balance);
                    amount = Double.Parse(amountTB.Text);
                    totala = balancea - amount;
                    try
                    {
                        lqs = "SELECT * FROM dataTable WHERE  AccountNum = " + textBox1.Text + "";
                        cmdb.Connection = wkbnchCon;
                        cmdb.CommandText = lqs;
                        wkbnchDAb.SelectCommand = cmdb;
                        wkbnchDAb.Fill(wkbnchDTblb);
                        if (wkbnchDTblb.Rows.Count > 0)
                        {
                            Fullname = (wkbnchDTblb.Rows[0]["FirstName"]).ToString();
                            balance = (wkbnchDTblb.Rows[0]["Balance"]).ToString();
                            balanceb = Double.Parse(balance);
                            amount = Double.Parse(amountTB.Text);
                            totalb = balanceb + amount;
                            TransReciptForm.Default.Show();
                            TransReciptForm.Default.label4.Text = balance;
                            TransReciptForm.Default.label3.Text = Fullname;
                            TransReciptForm.Default.label6.Text = amount.ToString();
                            TransReciptForm.Default.label4.Text = balanceb.ToString();
                            TransReciptForm.Default.label8.Text = accnmLBL.Text;
                            TransReciptForm.Default.label7.Text = totalb.ToString();
                            TransReciptForm.Default.lblttlb.Text = totala.ToString();
                            TransReciptForm.Default.lbltrnsfr.Text = Fullnamee;
                            TransReciptForm.Default.label5.Show();
                            TransReciptForm.Default.label8.Show();
                            TransReciptForm.Default.label6.Show();
                            TransReciptForm.Default.label4.Show();
                            TransReciptForm.Default.label6.Show();
                            this.Hide();

                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Please enter your desired amount");
                    }
                }
            }
            catch { }
            amountTB.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnclBTTN_Click(object sender, EventArgs e)
        {
            MainForm.Default.Show();
            this.Hide();
        }

    }
}
