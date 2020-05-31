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
    public partial class Gen : Form
    {
        public Gen()
        {
            InitializeComponent();
        }
        public static string selectedID;
        private void Gen_Load(object sender, EventArgs e)
        {
            PatientID.Text = Form1.selectedID;
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Select PtLastName, PtFirstname, DOB from Patienttable where PatientID=" + PatientID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Lname.Text = reader[0].ToString();
                Fname.Text = reader[1].ToString();
                AGE.Text = reader[2].ToString();

            }

            reader.Close();

            cmd.CommandText = "Select GeneralMedicalHistoryID from generalmedicalhistorytable where PatientID=" + PatientID.Text;
            OleDbDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                listBox1.Items.Add(reader2[0].ToString());

            }
            reader2.Close();

          
            connection.Close();

        }

        private void label9_Click(object sender, EventArgs e)
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

                cmd.CommandText = "Select Pregnancies, Tobacco, Alcohol from generalmedicalhistorytable where GeneralMedicalhistoryID=" + listBox1.SelectedItem.ToString();
                OleDbDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    GenID.Text = listBox1.SelectedItem.ToString();
                    Preg.Text = reader2[0].ToString();
                    Tab.Text = reader2[1].ToString();
                    Alcohol.Text = reader2[2].ToString();
                }
                reader2.Close();
                connection.Close();
            }

            catch
            {

                MessageBox.Show("Please select a General Medical History ID");
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.Connection = connection;


            cmd.CommandText = "Update generalmedicalhistorytable set Pregnancies =" + "'" + Preg.Text + "'" + ",Tobacco =" + "'" + Tab.Text + "'" + ",Alcohol=" + "'" + Alcohol.Text + "'" + " where GeneralMedicalhistoryID=" + listBox1.SelectedItem.ToString();
            OleDbDataReader reader2 = cmd.ExecuteReader();
            reader2.Read();
            reader2.Close();


            this.BackColor = Color.LightBlue;


            Preg.ReadOnly = true;
            Tab.ReadOnly = true;
            Alcohol.ReadOnly = true;

            Save.Hide();
            Add.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Insert into generalmedicalhistorytable (PatientID, Pregnancies, Tobacco, Alcohol) VALUES" + "(" + "'" + PatientID.Text + "'" + "," + "'" + Preg.Text + "'" + "," + "'" + Tab.Text + "'" + "," + "'" + Alcohol.Text + "'" + ")";
            cmd.Connection = connection;


            OleDbDataReader reader = cmd.ExecuteReader();

            connection.Close();
            this.BackColor = Color.LightBlue;
            Preg.ReadOnly = true;
            Tab.ReadOnly = true;
            Alcohol.ReadOnly = true;
            listBox1.Update();

            Add.Hide();
            Save.Hide();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

            Preg.ReadOnly = false;
            Tab.ReadOnly = false;
            Alcohol.ReadOnly = false;

            Save.Show();
            Add.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Delete from generalmedicalhistorytable where GeneralMedicalhistoryID=" + GenID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();

            MessageBox.Show("Deleted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            Form3 allergies = new Form3();
            allergies.Show();
            this.Hide();

        }

        private void Demo_Click(object sender, EventArgs e)
        {
            Form2 demofrm = new Form2();
            demofrm.Show();
            this.Hide();
        }

        private void Illness_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            illness illform = new illness();
            illform.Show();
            this.Hide();
        }

        private void Family_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            FamilyForm famform = new FamilyForm();
            famform.Show();
            this.Hide();
        }
    }
}
