using System;
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
    public partial class FamilyForm : Form
    {
        public FamilyForm()
        {
            InitializeComponent();
        }
        public static string selectedID;
        private void FamilyForm_Load(object sender, EventArgs e)
        {
           

            PatientID.Text = Form2.selectedID;
         

            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Select PtLastName, PtFirstname, DOB from Patienttable where PatientID=" + PatientID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();

            reader.Read();
                Lname.Text = reader[0].ToString();
                Fname.Text = reader[1].ToString();
                AGE.Text = reader[2].ToString();
            reader.Close();
                    

            cmd.CommandText = "Select FamilyID from familyhistorytable where PatientID=" + PatientID.Text;
            OleDbDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                listBox1.Items.Add(reader2[0].ToString());

            }
            reader2.Close();

            connection.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
              "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.Connection = connection;

            try
            {
                cmd.CommandText = "Select Name, Relation, MajorDisorder from familyhistorytable where FamilyID=" + listBox1.SelectedItem.ToString();
                OleDbDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    FamID.Text = listBox1.SelectedItem.ToString();
                    Nah.Text = reader2[0].ToString();
                    Relationship.Text = reader2[1].ToString();
                    MJ.Text = reader2[2].ToString();
                }
                reader2.Close();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Please select a Family ID");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //save button
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.Connection = connection;


            cmd.CommandText = "Update familyhistorytable set Name =" + "'" + Nah.Text + "'" + ",Relation =" + "'" + Relationship.Text + "'" + ",MajorDisorder=" +"'"+ MJ.Text +"'" +" where FamilyID=" + listBox1.SelectedItem.ToString();
            OleDbDataReader reader2 = cmd.ExecuteReader();
            reader2.Read();
            reader2.Close();


            this.BackColor = Color.LightBlue;


            Nah.ReadOnly = true;
            Relationship.ReadOnly = true;
            MJ.ReadOnly = true;

            button1.Hide();
            AddButton.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Delete from familyhistorytable where FamilyID=" + FamID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();

            MessageBox.Show("Deleted");
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

            Nah.ReadOnly = false;
            Relationship.ReadOnly = false;
            MJ.ReadOnly = false;

            button1.Show();
            AddButton.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Insert into familyhistorytable (PatientID,Name, Relation,MajorDisorder) VALUES" + "(" +"'"+PatientID.Text+"'"+ ","+"'" + Nah.Text + "'" + "," + "'" + Relationship.Text + "'" + "," + "'" + MJ.Text + "'" + ")";
            cmd.Connection = connection;


            OleDbDataReader reader = cmd.ExecuteReader();

            connection.Close();
            this.BackColor = Color.LightBlue;
            Nah.ReadOnly = true;
            Relationship.ReadOnly = true;
            MJ.ReadOnly = true;
            listBox1.Update();

            AddButton.Hide();
            button1.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Allergy_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            Form3 allergies = new Form3();
            allergies.Show();
            this.Hide();
        }

        private void Illness_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            illness illform = new illness();
            illform.Show();
            this.Hide();
        }

        private void Demo_Click(object sender, EventArgs e)
        {
            Form2 demofrm = new Form2();
            demofrm.Show();
            this.Hide();
        }

        private void FamID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Med_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            Gen genfrm = new Gen();
            genfrm.Show();
            this.Hide();
        }
    }
}
