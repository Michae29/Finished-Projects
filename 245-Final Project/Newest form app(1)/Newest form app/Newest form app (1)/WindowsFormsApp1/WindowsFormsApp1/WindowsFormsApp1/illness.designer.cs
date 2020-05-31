namespace WindowsFormsApp1
{
    partial class illness
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
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.AGE = new System.Windows.Forms.TextBox();
            this.PatientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.modifybutton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.illy = new System.Windows.Forms.TextBox();
            this.DOI = new System.Windows.Forms.TextBox();
            this.Resolve = new System.Windows.Forms.TextBox();
            this.illID = new System.Windows.Forms.TextBox();
            this.Fam = new System.Windows.Forms.Button();
            this.Demo = new System.Windows.Forms.Button();
            this.Allergies = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Med = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.Yellow;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(237, 113);
            this.Lname.Margin = new System.Windows.Forms.Padding(2);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(76, 26);
            this.Lname.TabIndex = 0;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.Yellow;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(332, 113);
            this.Fname.Margin = new System.Windows.Forms.Padding(2);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(76, 26);
            this.Fname.TabIndex = 1;
            // 
            // AGE
            // 
            this.AGE.BackColor = System.Drawing.Color.Yellow;
            this.AGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE.Location = new System.Drawing.Point(424, 112);
            this.AGE.Margin = new System.Windows.Forms.Padding(2);
            this.AGE.Name = "AGE";
            this.AGE.Size = new System.Drawing.Size(76, 26);
            this.AGE.TabIndex = 2;
            // 
            // PatientID
            // 
            this.PatientID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PatientID.Location = new System.Drawing.Point(90, 112);
            this.PatientID.Margin = new System.Windows.Forms.Padding(2);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(76, 20);
            this.PatientID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(566, 112);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 95);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PatientID";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(98, 301);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 24);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(159, 301);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(56, 24);
            this.Addbutton.TabIndex = 11;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Visible = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // modifybutton
            // 
            this.modifybutton.Location = new System.Drawing.Point(219, 300);
            this.modifybutton.Margin = new System.Windows.Forms.Padding(2);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(56, 24);
            this.modifybutton.TabIndex = 12;
            this.modifybutton.Text = "Modify";
            this.modifybutton.UseVisualStyleBackColor = true;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(279, 300);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 24);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 301);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 24);
            this.button5.TabIndex = 14;
            this.button5.Text = "Undo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // illy
            // 
            this.illy.Location = new System.Drawing.Point(161, 187);
            this.illy.Margin = new System.Windows.Forms.Padding(2);
            this.illy.Name = "illy";
            this.illy.Size = new System.Drawing.Size(76, 20);
            this.illy.TabIndex = 15;
            // 
            // DOI
            // 
            this.DOI.Location = new System.Drawing.Point(161, 209);
            this.DOI.Margin = new System.Windows.Forms.Padding(2);
            this.DOI.Name = "DOI";
            this.DOI.Size = new System.Drawing.Size(76, 20);
            this.DOI.TabIndex = 16;
            // 
            // Resolve
            // 
            this.Resolve.Location = new System.Drawing.Point(161, 232);
            this.Resolve.Margin = new System.Windows.Forms.Padding(2);
            this.Resolve.Name = "Resolve";
            this.Resolve.Size = new System.Drawing.Size(76, 20);
            this.Resolve.TabIndex = 17;
            // 
            // illID
            // 
            this.illID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.illID.Location = new System.Drawing.Point(161, 164);
            this.illID.Margin = new System.Windows.Forms.Padding(2);
            this.illID.Name = "illID";
            this.illID.ReadOnly = true;
            this.illID.Size = new System.Drawing.Size(76, 20);
            this.illID.TabIndex = 18;
            this.illID.TextChanged += new System.EventHandler(this.illID_TextChanged);
            // 
            // Fam
            // 
            this.Fam.Location = new System.Drawing.Point(566, 253);
            this.Fam.Name = "Fam";
            this.Fam.Size = new System.Drawing.Size(84, 23);
            this.Fam.TabIndex = 19;
            this.Fam.Text = "Open Family";
            this.Fam.UseVisualStyleBackColor = true;
            this.Fam.Click += new System.EventHandler(this.Fam_Click);
            // 
            // Demo
            // 
            this.Demo.Location = new System.Drawing.Point(566, 311);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(123, 23);
            this.Demo.TabIndex = 20;
            this.Demo.Text = "Open Demographics";
            this.Demo.UseVisualStyleBackColor = true;
            this.Demo.Click += new System.EventHandler(this.Demo_Click);
            // 
            // Allergies
            // 
            this.Allergies.Location = new System.Drawing.Point(566, 282);
            this.Allergies.Name = "Allergies";
            this.Allergies.Size = new System.Drawing.Size(84, 23);
            this.Allergies.TabIndex = 21;
            this.Allergies.Text = "Open Allergies";
            this.Allergies.UseVisualStyleBackColor = true;
            this.Allergies.Click += new System.EventHandler(this.Allergies_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Illness Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Illness ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Illness name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Date of Infection";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Date resolved";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Illness ID";
            // 
            // Med
            // 
            this.Med.Location = new System.Drawing.Point(566, 341);
            this.Med.Name = "Med";
            this.Med.Size = new System.Drawing.Size(84, 23);
            this.Med.TabIndex = 28;
            this.Med.Text = "Open Medical";
            this.Med.UseVisualStyleBackColor = true;
            this.Med.Click += new System.EventHandler(this.Med_Click);
            // 
            // illness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(964, 482);
            this.Controls.Add(this.Med);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Allergies);
            this.Controls.Add(this.Demo);
            this.Controls.Add(this.Fam);
            this.Controls.Add(this.illID);
            this.Controls.Add(this.Resolve);
            this.Controls.Add(this.DOI);
            this.Controls.Add(this.illy);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifybutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Lname);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "illness";
            this.Text = "illness";
            this.Load += new System.EventHandler(this.illness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.TextBox PatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button modifybutton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox illy;
        private System.Windows.Forms.TextBox DOI;
        private System.Windows.Forms.TextBox Resolve;
        private System.Windows.Forms.TextBox illID;
        private System.Windows.Forms.Button Fam;
        private System.Windows.Forms.Button Demo;
        private System.Windows.Forms.Button Allergies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Med;
    }
}