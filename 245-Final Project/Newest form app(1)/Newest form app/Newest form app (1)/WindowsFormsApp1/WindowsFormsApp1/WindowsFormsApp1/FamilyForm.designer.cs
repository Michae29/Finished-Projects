namespace WindowsFormsApp1
{
    partial class FamilyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PatientID = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.AGE = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FamID = new System.Windows.Forms.TextBox();
            this.Nah = new System.Windows.Forms.TextBox();
            this.Relationship = new System.Windows.Forms.TextBox();
            this.MJ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Allergy = new System.Windows.Forms.Button();
            this.Demo = new System.Windows.Forms.Button();
            this.Illness = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Med = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientID
            // 
            this.PatientID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PatientID.Location = new System.Drawing.Point(163, 81);
            this.PatientID.Margin = new System.Windows.Forms.Padding(2);
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Size = new System.Drawing.Size(76, 20);
            this.PatientID.TabIndex = 0;
            this.PatientID.TextChanged += new System.EventHandler(this.PatientID_TextChanged);
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.Yellow;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(310, 81);
            this.Lname.Margin = new System.Windows.Forms.Padding(2);
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Size = new System.Drawing.Size(76, 26);
            this.Lname.TabIndex = 1;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.Yellow;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(419, 81);
            this.Fname.Margin = new System.Windows.Forms.Padding(2);
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Size = new System.Drawing.Size(76, 26);
            this.Fname.TabIndex = 2;
            // 
            // AGE
            // 
            this.AGE.BackColor = System.Drawing.Color.Yellow;
            this.AGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE.Location = new System.Drawing.Point(540, 80);
            this.AGE.Margin = new System.Windows.Forms.Padding(2);
            this.AGE.Name = "AGE";
            this.AGE.ReadOnly = true;
            this.AGE.Size = new System.Drawing.Size(76, 26);
            this.AGE.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(702, 81);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 69);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Family ID list";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FamID
            // 
            this.FamID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FamID.Location = new System.Drawing.Point(254, 185);
            this.FamID.Margin = new System.Windows.Forms.Padding(2);
            this.FamID.Name = "FamID";
            this.FamID.ReadOnly = true;
            this.FamID.Size = new System.Drawing.Size(76, 20);
            this.FamID.TabIndex = 14;
            this.FamID.TextChanged += new System.EventHandler(this.FamID_TextChanged);
            // 
            // Nah
            // 
            this.Nah.Location = new System.Drawing.Point(254, 224);
            this.Nah.Margin = new System.Windows.Forms.Padding(2);
            this.Nah.Name = "Nah";
            this.Nah.Size = new System.Drawing.Size(76, 20);
            this.Nah.TabIndex = 15;
            // 
            // Relationship
            // 
            this.Relationship.Location = new System.Drawing.Point(254, 260);
            this.Relationship.Margin = new System.Windows.Forms.Padding(2);
            this.Relationship.Name = "Relationship";
            this.Relationship.Size = new System.Drawing.Size(76, 20);
            this.Relationship.TabIndex = 16;
            // 
            // MJ
            // 
            this.MJ.Location = new System.Drawing.Point(254, 295);
            this.MJ.Margin = new System.Windows.Forms.Padding(2);
            this.MJ.Name = "MJ";
            this.MJ.Size = new System.Drawing.Size(76, 20);
            this.MJ.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 22);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(334, 368);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(56, 22);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(394, 368);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(56, 22);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(454, 368);
            this.Modify.Margin = new System.Windows.Forms.Padding(2);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(56, 22);
            this.Modify.TabIndex = 21;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(519, 368);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 22);
            this.button5.TabIndex = 22;
            this.button5.Text = "Undo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Allergy
            // 
            this.Allergy.Location = new System.Drawing.Point(685, 276);
            this.Allergy.Name = "Allergy";
            this.Allergy.Size = new System.Drawing.Size(108, 23);
            this.Allergy.TabIndex = 23;
            this.Allergy.Text = "Open Allergies";
            this.Allergy.UseVisualStyleBackColor = true;
            this.Allergy.Click += new System.EventHandler(this.Allergy_Click);
            // 
            // Demo
            // 
            this.Demo.Location = new System.Drawing.Point(685, 334);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(126, 23);
            this.Demo.TabIndex = 24;
            this.Demo.Text = "Open Demographics";
            this.Demo.UseVisualStyleBackColor = true;
            this.Demo.Click += new System.EventHandler(this.Demo_Click);
            // 
            // Illness
            // 
            this.Illness.Location = new System.Drawing.Point(685, 305);
            this.Illness.Name = "Illness";
            this.Illness.Size = new System.Drawing.Size(108, 23);
            this.Illness.TabIndex = 25;
            this.Illness.Text = "Open Illness";
            this.Illness.UseVisualStyleBackColor = true;
            this.Illness.Click += new System.EventHandler(this.Illness_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Family Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Family ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Relationship";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Disorder";
            // 
            // Med
            // 
            this.Med.Location = new System.Drawing.Point(685, 247);
            this.Med.Name = "Med";
            this.Med.Size = new System.Drawing.Size(108, 23);
            this.Med.TabIndex = 32;
            this.Med.Text = "Open Medical";
            this.Med.UseVisualStyleBackColor = true;
            this.Med.Click += new System.EventHandler(this.Med_Click);
            // 
            // FamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(902, 417);
            this.Controls.Add(this.Med);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Illness);
            this.Controls.Add(this.Demo);
            this.Controls.Add(this.Allergy);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MJ);
            this.Controls.Add(this.Relationship);
            this.Controls.Add(this.Nah);
            this.Controls.Add(this.FamID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.PatientID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FamilyForm";
            this.Text = "FamilyForm";
            this.Load += new System.EventHandler(this.FamilyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatientID;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FamID;
        private System.Windows.Forms.TextBox Nah;
        private System.Windows.Forms.TextBox Relationship;
        private System.Windows.Forms.TextBox MJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Allergy;
        private System.Windows.Forms.Button Demo;
        private System.Windows.Forms.Button Illness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Med;
    }
}