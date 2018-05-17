﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void member_Time_inBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.member_Time_inBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._5801DataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_5801DataSet._Member_Time_in' table. You can move, or remove it, as needed.
            this.member_Time_inTableAdapter.Fill(this._5801DataSet._Member_Time_in);

            string ConString = ConfigurationManager.ConnectionStrings["SignIn.Properties.Settings._5801ConnectionString"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(ConString))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT [First Name] FROM Members", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                first_NameTextBox.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            using (OleDbConnection con2 = new OleDbConnection(ConString))
            {
                OleDbCommand cmd2 = new OleDbCommand("SELECT [Last Name] FROM Members", con2);
                con2.Open();
                OleDbDataReader reader = cmd2.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                last_NameTextBox.AutoCompleteCustomSource = MyCollection;
                con2.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idautofill();

            if (iDTextBox.Text == "")
            {
                MessageBox.Show("Please check the spelling of your name!");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _5801DataSet._Member_Time_inRow new_Member_Time_inRow =
                this._5801DataSet._Member_Time_in.New_Member_Time_inRow();
        }

        private void meeting_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        public void idautofill() //good luck
        {
            var a = first_NameTextBox.Text;
            var b = last_NameTextBox.Text;
            string ConString = ConfigurationManager.ConnectionStrings["SignIn.Properties.Settings._5801ConnectionString"].ConnectionString;
            using (OleDbConnection con3 = new OleDbConnection(ConString))
            {
                OleDbCommand cmd3 = new OleDbCommand("SELECT [ID] FROM Members WHERE [First Name]='" + a + "' AND [Last Name]='" + b + "'", con3);
                con3.Open();
                OleDbDataReader reader = cmd3.ExecuteReader();
                while (reader.Read())
                {
                    string c = reader[0].ToString();
                    iDTextBox.Text = c;
                }
            con3.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
