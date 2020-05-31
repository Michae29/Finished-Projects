﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public static string selectedID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Select PatientID from Patienttable";
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());

            }
            reader.Close();

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedID = listBox1.SelectedItem.ToString();
            Form2 demofrm = new Form2();
            demofrm.Show();
            this.Hide();

        }
    }
}
