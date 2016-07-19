using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;



namespace WindowsFormsApplication1
{
	public partial class ManagerForm : Form
	{
		public ManagerForm()
		{
			InitializeComponent();				
		}
		
		
		private static ManagerForm defaultInstance;
		
		public static ManagerForm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new ManagerForm();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(Object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}

        MySqlConnectionStringBuilder strbld = new MySqlConnectionStringBuilder();
		MySqlDataAdapter wkbnchDA = new MySqlDataAdapter();
		MySqlConnection wkbnchCon = new MySqlConnection();
		DataTable dt = new DataTable();
		string sql;
        MySqlCommand cmd = new MySqlCommand();
		
		public void ManagerForm_Load(Object sender, EventArgs e)
		{
            wkbnchCon.ConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=toor;database=bankschema;";
			lblDate.Text = DateTime.Now.ToString();
            strbld.Server = "localhost";
            strbld.UserID = "root";
            strbld.Password = "toor";
            strbld.Database = "bankschema";
			txtfname.Enabled = false;
			txtlname.Enabled = false;
			bttnRestrict.Enabled = false;
			bttnPermit.Enabled = false;
			GroupBox2.Enabled = false;
			bttnConfirm.Enabled = false;
        }

        public void bttnUpdate_Click(Object sender, EventArgs e)
		{
			wkbnchCon.Open();	
			sql = "UPDATE datatable SET AccountNum=\'" + txtAcctNo.Text + "\',PIN=\'" + txtPincode.Text + "\',FirstName=\'" + txtfnme.Text + "\',LastName=\'" + txtlnme.Text + "\',Address=\'" + txtaddr.Text + "\',ContactNumber=\'" + txtcontact.Text + "\',Gender=\'" + cbGender.Text + "\'WHERE FirstName=\'" + lblhide.Text + "\'";
			cmd.CommandText = sql;
			cmd.Connection = wkbnchCon;
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			MessageBox.Show("Client data updated successfully!");
			wkbnchCon.Close();
			DataGridView1.Refresh();

        }

        public void bttnCancel_Click(Object sender, EventArgs e)
		{
			GroupBox2.Enabled = false;
			bttnEdit.Enabled = true;
			bttnSearch.Enabled = true;
        }

        public void bttnRestrict_Click(Object sender, EventArgs e)
		{
			wkbnchCon.Open();			
			MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM datatable", wkbnchCon);			
			sql = "UPDATE datatable SET type=\'" + "Block" + "\'" + " WHERE FirstName =\'" + txtfnme.Text + "\'";
			cmd.CommandText = sql;
			cmd.Connection = wkbnchCon;
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			MessageBox.Show("Client blocked successfully!");			
			wkbnchCon.Close();
			loadData_Click(sender, e);
		}

        public void bttnPermit_Click(Object sender, EventArgs e)
		{
			wkbnchCon.Open();		
			MySqlDataAdapter ad = new MySqlDataAdapter("select * from datatable", wkbnchCon);		
			sql = "UPDATE datatable SET type=\'" + "Active" + "\'" + " Where Firstname =\'" + txtfnme.Text + "\'";
			cmd.CommandText = sql;
			cmd.Connection = wkbnchCon;
			cmd.ExecuteNonQuery();
			cmd.Dispose();
            MessageBox.Show("Client unblocked successfully!");
			wkbnchCon.Close();
			loadData_Click(sender, e);
		}

        private void loadData_Click(Object sender, EventArgs e)
        {
            wkbnchCon.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM dataTable", wkbnchCon);
            DataSet data = new DataSet();
            ad.Fill(data, "info");
            DataGridView1.DataSource = data.Tables["info"].DefaultView;
            data.Dispose();
            ad.Dispose();
            wkbnchCon.Close();
        }

        private void bttnEdit_Click(Object sender, EventArgs e)
        {
            GroupBox2.Enabled = true;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnPermit.Enabled = true;
            bttnRestrict.Enabled = true;
        }

        private void bttnSearch_Click(Object sender, EventArgs e)
        {
            txtfname.Enabled = true;
            txtlname.Enabled = true;
            bttnConfirm.Enabled = true;
        }

        private void bttnConfirm_Click(Object sender, EventArgs e)
        {
            sql = "SELECT * FROM datatable WHERE Firstname=\'" + txtfname.Text + "\'" + "and Lastname= \'" + txtlname.Text + "\'";
            try
            {
                wkbnchCon.Open();
                wkbnchDA = new MySqlDataAdapter(sql, wkbnchCon);
                wkbnchDA.Fill(dt);
                DataGridView1.DataSource = dt;
            }
            catch (Exception exp){}
            wkbnchCon.Close();
            bttnConfirm.Enabled = false;
        }

        private void bttnLogout_Click(Object sender, EventArgs e)
        {
            LoginForm.Default.Show();
            this.Hide();
        }
	}
}
