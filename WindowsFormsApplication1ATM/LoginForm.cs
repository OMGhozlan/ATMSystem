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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private static LoginForm defaultInstance;


        public static LoginForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new LoginForm();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(Object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }



        private void LoginForm_Load(Object sender, EventArgs e){}

        private void textBox1_TextChanged(Object sender, EventArgs e){}

        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter wkbnchDA = new MySqlDataAdapter();
        DataSet wkbnchDSet = new DataSet();
        MySqlConnection wkbnchCon = new MySqlConnection();

        private void loginBTTN_Click(object sender, EventArgs e)
        {
            string sql = default(string);
            DataTable wkbnchDTblA = new DataTable();
            try
            {
                if (pinTB.Text == "")
                {
                    MessageBox.Show("Please Enter Your PIN Code");
                }
                else
                {
                    wkbnchCon.ConnectionString = "server=127.0.0.1;uid=root;" +
                    "pwd=toor;database=bankschema;";
                    sql = "SELECT * FROM datatable where PIN = " + pinTB.Text + "";
                    cmd.Connection = wkbnchCon;
                    cmd.CommandText = sql;
                    wkbnchDA.SelectCommand = cmd;
                    wkbnchDA.Fill(wkbnchDTblA);
                    if (wkbnchDTblA.Rows.Count > 0)
                    {
                        string Type;
                        string Fullname = default(string);
                        string accno = default(string);
                        Type = (wkbnchDTblA.Rows[0]["AccessType"]).ToString();
                        Fullname = (wkbnchDTblA.Rows[0]["FirstName"]).ToString();
                        accno = Convert.ToString((wkbnchDTblA.Rows[0]["AccountNum"]));
                        if (Type == "Admin")
                        {
                            MessageBox.Show("Welcome " + Fullname + " you're logged in as Administrator ");
                            ManagerForm.Default.Show();
                            this.Hide();
                        }
                        else if (Type == "Block")
                        {
                            MessageBox.Show("Your account is currently blocked");
                            MessageBox.Show("Contact the Administrator for Help");
                        }
                        else
                        {
                            MessageBox.Show("Welcome " + Fullname);
                            MainForm.Default.label1.Text = accno;
                            MainForm.Default.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are not a registered client");
                        MessageBox.Show("Please proceeed to the registeration page");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pinTB.Text = "";
			
        }

        private void regBTTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm.Default.Show();
        }
    }
}
