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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            wkbnchCStr = "server=127.0.0.1;uid=root;" +
            "pwd=toor;database=bankschema;";
            wkbnchCon = new MySqlConnection(wkbnchCStr);
            InitializeComponent();
        }

        private static RegForm defaultInstance;


        public static RegForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new RegForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }


        private void RegForm_Load(object sender, EventArgs e)
        {
            wkbnchCon.ConnectionString = wkbnchCStr;
            wkbnchCon.Open();
        }

        string wkbnchCStr;
        MySqlDataAdapter wkbnchAdaptA = new MySqlDataAdapter();
        MySqlConnection wkbnchCon;
        DataSet wkbnchDSet = new DataSet();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void regBTTN_Click(object sender, EventArgs e)
        {
            //if (accntnoTB.Text == "" && pinTB.Text == "" && fstnmTB.Text == "" && mddlnmTB.Text == "" && lstnmTB.Text == "" && addrsTB.Text == "" && phnTB.Text == "" && genderCB.Text == "" && dayCB.Text == "" && monthCB.Text == "" && yearCB.Text == "")
            if (pinTB.Text == "" && fstnmTB.Text == "" && mddlnmTB.Text == "" && lstnmTB.Text == "" && addrsTB.Text == "" && phnTB.Text == "" && genderCB.Text == "" && dayCB.Text == "" && monthCB.Text == "" && yearCB.Text == "")
            {
                MessageBox.Show("Please Enter All Fields");

            }
            //else if (accntnoTB.Text == "" || pinTB.Text == "" || fstnmTB.Text == "" || mddlnmTB.Text == "" || lstnmTB.Text == "" || addrsTB.Text == "" || phnTB.Text == "" || genderCB.Text == "" || dayCB.Text == "" || monthCB.Text == "" || yearCB.Text == "")
            else if (pinTB.Text == "" || fstnmTB.Text == "" || mddlnmTB.Text == "" || lstnmTB.Text == "" || addrsTB.Text == "" || phnTB.Text == "" || genderCB.Text == "" || dayCB.Text == "" || monthCB.Text == "" || yearCB.Text == "")
            {
                MessageBox.Show("Please Complete The Missing Fields");

            }
            else
            {
                MySqlDataAdapter wkbnchAdaptA = new MySqlDataAdapter("SELECT * from dataTable where Firstname=\'" + fstnmTB.Text + "\'", wkbnchCon);
                DataSet wkbnchDSetA = new DataSet();
                wkbnchAdaptA.Fill(wkbnchDSetA);
                if (wkbnchDSetA.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Account name already exists");
                }
                else
                {
                    string dbcommand = "INSERT into dataTable (AccountNum, FirstName, MiddleName, LastName, Address, ContactNumber, Gender, DateOfBirth, PIN, AccessType, Balance)" + " VALUES (\'" + ((Program.NameHasher(fstnmTB.Text, mddlnmTB.Text, lstnmTB.Text)).ToString() + "\',\'") + fstnmTB.Text + "\',\'" + mddlnmTB.Text + "\',\'" + lstnmTB.Text + "\',\'" + addrsTB.Text + "\',\'" + phnTB.Text + "\',\'" + genderCB.Text + "\',\'" + (yearCB.Text + "-" + monthCB.Text + "-" + dayCB.Text) + "\',\'" + pinTB.Text + "\',\'" + "Active" + "\',\'" + "1000" + "\')";
                    MySqlDataAdapter wkbnchAdapt = new MySqlDataAdapter(dbcommand, wkbnchCon);
                    DataSet wkbnchDSet = new DataSet();
                    wkbnchAdapt.Fill(wkbnchDSet);
                    MessageBox.Show("You Have Succesfully Registered on" + " " + DateTime.Now.ToString() + "!");
                    this.Hide();
                    LoginForm.Default.Show();
                }
            }
        }

        private void cnclBTTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Default.Show();
        }
    }
}
