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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string selectedID;
        /////Working form load No touch ////////////

        private void Form3_Load(object sender, EventArgs e)
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

            cmd.CommandText = "Select AllergyID from allergyhistorytable where PatientID="+PatientID.Text;
            cmd.Connection = connection;

            OleDbDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                listBox1.Items.Add(reader2[0].ToString());

            }

            reader2.Close();
            connection.Close();

            
                 
        }
        ////// Open demo form button/////
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 demofrm = new Form2();
            demofrm.Show();
            this.Hide();
        }
        ////// Works fine but along with save button don't use apostrophe /////////
        private void Add_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Insert into allergyhistorytable (PatientID,Allergen,AllergyDescription) VALUES" + "("+"'"+PatientID.Text+"'"+","+"'"+Allergen.Text+"'"+","+"'"+Description.Text+"'"+")";
            cmd.Connection = connection;


            OleDbDataReader reader = cmd.ExecuteReader();
            connection.Close();

            this.BackColor = Color.LightBlue;
          
        
            Allergen.ReadOnly = true;
            Description.ReadOnly = true;
            Save.Hide();
            AddButton.Hide();
        }
        ///////unlocks all the boxes essentially for now //////
        private void Modify_Click(object sender, EventArgs e)
        {
            Modname Amod = new Modname(Allergen.Text, Description.Text);
            Undo_Click(Amod, e);

            this.BackColor = Color.Blue;
        
            Allergen.ReadOnly = false;
            Description.ReadOnly = false;
            Save.Show();
            AddButton.Show();
        }
        ////Works but DO NOT USE AN APOSTROPHE IN TEXT it recognizes as the end of the string and breaks///
        private void Save_Click(object sender, EventArgs e)
        {

            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.Connection = connection;


            cmd.CommandText = "Update allergyhistorytable set Allergen =" + "'" + Allergen.Text + "'" + ",AllergyDescription = " + "'" + Description.Text + "'" + " where AllergyID=" + listBox1.SelectedItem.ToString();
            OleDbDataReader reader2 = cmd.ExecuteReader();
            reader2.Read();
            reader2.Close();


            this.BackColor = Color.LightBlue;
         
           
            Allergen.ReadOnly = true;
            Description.ReadOnly = true;
            Save.Hide();
            AddButton.Hide();

        }
        ////////        Working on undo button      ///////
        private void Undo_Click(object sender, EventArgs e)
        {
            Modname Bmod = sender as Modname;

            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();


            cmd.CommandText = "Update allergyhistorytable set Allergen =" + "'" + Bmod.Allergen + "'" + ",AllergyDescription = " + "'" + Bmod.Allergen + "'" + " where AllergyID=" + listBox1.SelectedItem.ToString();
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            reader.Close();


            Allergen.ReadOnly = true;
            Description.ReadOnly = true;
            Save.Hide();
            AddButton.Hide();
        }

        ////// Works but actually deletes record not marks for deletion /////
        private void Delete_Click(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand cmd = connection.CreateCommand();

            connection.Open();

            cmd.CommandText = "Delete from allergyhistorytable where AllergyID=" + listBox1.SelectedItem.ToString();
            cmd.Connection = connection;

            OleDbDataReader reader = cmd.ExecuteReader();
        }
        ///// Selects AllergyID, need to figure out how to refresh it with new or deleted entries/////
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=E:\\ITS245\\STEFPROJ\\Database11.accdb";

                OleDbConnection connection = new OleDbConnection(connString);
                OleDbCommand cmd = connection.CreateCommand();

                connection.Open();

                cmd.CommandText = "Select allergen,AllergyDescription from allergyhistorytable where allergyID=" + listBox1.SelectedItem.ToString();
                cmd.Connection = connection;

                OleDbDataReader reader = cmd.ExecuteReader();

                reader.Read();

                Allergen.Text = reader[0].ToString();
                Description.Text = reader[1].ToString();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Please select a Allergy ID");
            }
            
        }

        private void Allergen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            illness illform = new illness();
            illform.Show();
            this.Hide();
        }

        private void fambutton_Click(object sender, EventArgs e)
        {
            selectedID = PatientID.Text;
            FamilyForm famform = new FamilyForm();
            famform.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
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
