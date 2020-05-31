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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string selectedID;
        private void Form2_Load(object sender, EventArgs e)
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


            cmd.CommandText = "Select PatientID from Patienttable";
       

            OleDbDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                listBox1.Items.Add(reader2[0].ToString());

            }
            reader2.Close();

            

            connection.Close();

        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

         //////////////     Modify Button        //////////
        private void Modify_Click(object sender, EventArgs e)
        {
            //// send it the object made from class and leave the e////
            Modname mod = new Modname(Fname.Text, Lname.Text, AGE.Text);
            Undo_Click(mod, e);

            this.BackColor = Color.Blue;
            Lname.ReadOnly = false;
            Fname.ReadOnly = false;
            AGE.ReadOnly = false;

            Save.Show();
            ADDButton.Show();
            
        }
        ////////////////////        Add Button          ///////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Insert into Patienttable (PtLastName, PtFirstName,DOB) VALUES"+"("+"'"+Lname.Text+"'"+","+"'"+Fname.Text+"'"+","+"'"+AGE.Text+"'"+")";
            cmd.Connection = connection;


            OleDbDataReader reader = cmd.ExecuteReader();

            connection.Close();
            this.BackColor = Color.LightBlue;
            Lname.ReadOnly = true;
            Fname.ReadOnly = true;
            AGE.ReadOnly = true;
            listBox1.Update();

            ADDButton.Hide();
            Save.Hide();

    

        }
        /////////////////    Undo Button     ////////////////////////

        private void Undo_Click(object sender,EventArgs e)
        {
            // Interprets sender as modname and sets mode equal to mod//
            Modname mode = sender as Modname;
            

            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

           

            cmd.CommandText = "Update patienttable set PtLastName = " + "'" + mode.Tlname + "'" + ",PtFirstname = " + "'" + mode.Tfname + "'" + ",DOB=" + "'" + mode.Dob + "'" + " where PatientID = " + PatientID.Text;
            OleDbDataReader reader2 = cmd.ExecuteReader();
            reader2.Read();
            reader2.Close();

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

            Lname.ReadOnly = true;
            Fname.ReadOnly = true;
            AGE.ReadOnly = true;
           

            connection.Close();
        }
        ////////////            Save Button         ////////////
        private void Save_Click(object sender, EventArgs e)
        {
          
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();
            
            cmd.Connection = connection;
            

            cmd.CommandText = "Update patienttable set PtLastName =" + "'" + Lname.Text + "'" + ",PtFirstname =" + "'" + Fname.Text + "'" + " where PatientID=" +PatientID.Text ;
            OleDbDataReader reader2 = cmd.ExecuteReader();
            reader2.Read();
            reader2.Close();

            connection.Close();

            this.BackColor = Color.LightBlue;
            Lname.ReadOnly = true;
            Fname.ReadOnly = true;
            AGE.ReadOnly = true;

            listBox1.Update();

            Save.Hide();
            ADDButton.Hide();
           
           
        }
        //////////////      Delete Button       /////////
        private void Delete_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Delete from Patienttable where PatientID=" + PatientID.Text;
            cmd.Connection = connection;
            
            OleDbDataReader reader = cmd.ExecuteReader();

            connection.Close();
           
                       

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AGE_TextChanged(object sender, EventArgs e)
        {

        }

        private void Allergies_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            Form3 allergies = new Form3();
            allergies.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

                OleDbConnection connection = new OleDbConnection(connString);
                OleDbCommand cmd = connection.CreateCommand();

                connection.Open();

                cmd.CommandText = "Select PtLastName, PtFirstname, DOB from Patienttable where PatientID=" + listBox1.SelectedItem.ToString();
                cmd.Connection = connection;

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PatientID.Text = listBox1.SelectedItem.ToString();
                    Lname.Text = reader[0].ToString();
                    Fname.Text = reader[1].ToString();
                    AGE.Text = reader[2].ToString();
                }

                reader.Close();
            }
            catch
            {
                MessageBox.Show("Please select a Patient ID");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            FamilyForm famform = new FamilyForm();
            famform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            illness illform = new illness();
            illform.Show();
            this.Hide();
        }

        private void Med_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            Gen genfrm = new Gen();
            genfrm.Show();
            this.Hide();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            String directoryName = "E:\\";
            const string FILENAME = "Report.txt";
            const string DELIM = ",";
            string fullPath = directoryName + "\\" + FILENAME;

            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";


            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(directoryName);
            }
            else
            {
                MessageBox.Show("Report has already been made");
            }
            FileStream outFile = new FileStream(fullPath, FileMode.Create, FileAccess.Write);

            StreamWriter writer1 = new StreamWriter(outFile);

            
            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Select PtLastName, PtFirstname, DOB from Patienttable where PatientID=" +PatientID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                writer1.WriteLine(reader[0].ToString() + DELIM + reader[1].ToString() + DELIM + reader[2]);
                
                
            }
            reader.Close();

            cmd.CommandText = "Select AllergyID,allergen,AllergyDescription from allergyhistorytable where PatientID=" + PatientID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                
                writer1.WriteLine(reader2[0].ToString()+DELIM+reader2[1]+DELIM+reader2[2]);
                
            }
            reader2.Close();

            cmd.CommandText = "Select FamilyID,Name,Relation,MajorDisorder from familyhistorytable where PatientID=" + PatientID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader3 = cmd.ExecuteReader();

            while (reader3.Read())
            {
                writer1.WriteLine(reader3[0].ToString() + DELIM + reader3[1].ToString() + DELIM + reader3[2].ToString()+DELIM+reader3[3].ToString());
            }
            reader3.Close();

            cmd.CommandText = "Select IllnessID,IllnessDate,Illness,Resolution from illnesshistorytable where PatientID=" + PatientID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader4 = cmd.ExecuteReader();

            while (reader4.Read())
            {
                writer1.WriteLine(reader4[0].ToString() + DELIM + reader4[1].ToString() + DELIM + reader4[2].ToString() + DELIM + reader4[3].ToString());
            }

            reader4.Close();

            MessageBox.Show("Finished report creation");

            connection.Close();

            writer1.Close();
            outFile.Close();

        }
    }
}
