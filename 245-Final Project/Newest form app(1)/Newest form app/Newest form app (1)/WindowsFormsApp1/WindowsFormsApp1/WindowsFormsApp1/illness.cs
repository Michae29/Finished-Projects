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
    public partial class illness : Form
    {
        public illness()
        {
            InitializeComponent();
        }
        public static string selectedID;

        private void illness_Load(object sender, EventArgs e)
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

            while (reader.Read())
            {
                Lname.Text = reader[0].ToString();
                Fname.Text = reader[1].ToString();
                AGE.Text = reader[2].ToString();

            }

            reader.Close();

            cmd.CommandText = "Select IllnessID from illnesshistorytable where patientID=" + PatientID.Text;
            OleDbDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                listBox1.Items.Add(reader2[0].ToString());

            }
            reader2.Close();

            //cmd.CommandText = "Select FamilyID, Name, Relation, MajorDisorder from familyhistorytable where PatientID=" + PatientID.Text;
            //OleDbDataReader reader3 = cmd.ExecuteReader();
            //while (reader3.Read())
            //{
            //    FamID.Text = reader3[0].ToString();
            //    Nah.Text = reader3[1].ToString();
            //    Relationship.Text = reader3[2].ToString();
            //    MJ.Text = reader3[3].ToString();
            //}
            //reader3.Close();
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();
                       
            
            try
            {
                cmd.CommandText = "Select Illness, IllnessDate, Resolution from illnesshistorytable where IllnessID=" + listBox1.SelectedItem.ToString();
                OleDbDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    illID.Text = listBox1.SelectedItem.ToString();
                    illy.Text = reader2[0].ToString();
                    DOI.Text = reader2[1].ToString();
                    Resolve.Text = reader2[2].ToString();
                }
                reader2.Close();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Please select and Illness ID");
            }
        }

        private void illID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.Connection = connection;


            cmd.CommandText = "Update illnesshistorytable set Illness =" + "'" + illy.Text + "'" + ",IllnessDate =" + "'" + DOI.Text + "'" + ",Resolution=" + "'" + Resolve.Text + "'" + " where IllnessID=" + listBox1.SelectedItem.ToString();
            OleDbDataReader reader2 = cmd.ExecuteReader();
            reader2.Read();
            reader2.Close();


            this.BackColor = Color.LightBlue;


            illy.ReadOnly = true;
            DOI.ReadOnly = true;
            Resolve.ReadOnly = true;

            save.Hide();
            Addbutton.Hide();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Insert into illnesshistorytable (Illness,PatientID,IllnessDate, Resolution) VALUES" + "(" + "'" + illy.Text + "'" +"," +"'"+PatientID.Text+"'"+","+ "'" + DOI.Text + "'" + "," + "'" + Resolve.Text + "'" + ")";
            cmd.Connection = connection;


            OleDbDataReader reader = cmd.ExecuteReader();

            connection.Close();
            this.BackColor = Color.LightBlue;
            illy.ReadOnly = true;
            DOI.ReadOnly = true;
            Resolve.ReadOnly = true;
            listBox1.Update();

            save.Hide();
            Addbutton.Hide();
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

            illy.ReadOnly = false;
            DOI.ReadOnly = false;
            Resolve.ReadOnly = false;
            save.Show();
            Addbutton.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Delete from illnesshistorytable where IllnessID="+illID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            reader.Close();

            MessageBox.Show("Deleted");
        }

        private void Fam_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            FamilyForm famform = new FamilyForm();
            famform.Show();
            this.Hide();
        }

        private void Allergies_Click(object sender, EventArgs e)
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

        private void Med_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            Gen genfrm = new Gen();
            genfrm.Show();
            this.Hide();
        }
    }
}
