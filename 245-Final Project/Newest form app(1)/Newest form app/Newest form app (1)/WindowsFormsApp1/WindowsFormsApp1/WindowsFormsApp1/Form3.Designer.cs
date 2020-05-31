namespace WindowsFormsApp1
{
    partial class Form3
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
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Allergen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fambutton = new System.Windows.Forms.Button();
            this.Illbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Med = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientID
            // 
            this.PatientID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PatientID.Location = new System.Drawing.Point(12, 29);
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Size = new System.Drawing.Size(100, 20);
            this.PatientID.TabIndex = 0;
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.Yellow;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Lname.Location = new System.Drawing.Point(153, 23);
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Size = new System.Drawing.Size(100, 26);
            this.Lname.TabIndex = 1;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.Yellow;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Fname.Location = new System.Drawing.Point(259, 23);
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Size = new System.Drawing.Size(100, 26);
            this.Fname.TabIndex = 2;
            // 
            // AGE
            // 
            this.AGE.BackColor = System.Drawing.Color.Yellow;
            this.AGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AGE.Location = new System.Drawing.Point(365, 23);
            this.AGE.Name = "AGE";
            this.AGE.ReadOnly = true;
            this.AGE.Size = new System.Drawing.Size(100, 26);
            this.AGE.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(25, 332);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Open Demographics";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(268, 332);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(187, 332);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 23);
            this.Undo.TabIndex = 7;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(106, 303);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(106, 332);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(75, 23);
            this.Modify.TabIndex = 9;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Allergen
            // 
            this.Allergen.Location = new System.Drawing.Point(162, 86);
            this.Allergen.Name = "Allergen";
            this.Allergen.ReadOnly = true;
            this.Allergen.Size = new System.Drawing.Size(100, 20);
            this.Allergen.TabIndex = 11;
            this.Allergen.TextChanged += new System.EventHandler(this.Allergen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Allergy Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Allergy Description";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(162, 156);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(100, 96);
            this.Description.TabIndex = 15;
            this.Description.Text = "";
            this.Description.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "AllergyID";
            // 
            // fambutton
            // 
            this.fambutton.Location = new System.Drawing.Point(427, 274);
            this.fambutton.Name = "fambutton";
            this.fambutton.Size = new System.Drawing.Size(85, 23);
            this.fambutton.TabIndex = 18;
            this.fambutton.Text = "Open Family";
            this.fambutton.UseVisualStyleBackColor = true;
            this.fambutton.Click += new System.EventHandler(this.fambutton_Click);
            // 
            // Illbutton
            // 
            this.Illbutton.Location = new System.Drawing.Point(427, 303);
            this.Illbutton.Name = "Illbutton";
            this.Illbutton.Size = new System.Drawing.Size(85, 23);
            this.Illbutton.TabIndex = 19;
            this.Illbutton.Text = "Open Illness";
            this.Illbutton.UseVisualStyleBackColor = true;
            this.Illbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Allergies Form";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Med
            // 
            this.Med.Location = new System.Drawing.Point(427, 245);
            this.Med.Name = "Med";
            this.Med.Size = new System.Drawing.Size(85, 23);
            this.Med.TabIndex = 21;
            this.Med.Text = "Open Medical";
            this.Med.UseVisualStyleBackColor = true;
            this.Med.Click += new System.EventHandler(this.Med_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(629, 384);
            this.Controls.Add(this.Med);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Illbutton);
            this.Controls.Add(this.fambutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Allergen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.PatientID);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.TextBox PatientID;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Allergen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fambutton;
        private System.Windows.Forms.Button Illbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Med;
    }
}