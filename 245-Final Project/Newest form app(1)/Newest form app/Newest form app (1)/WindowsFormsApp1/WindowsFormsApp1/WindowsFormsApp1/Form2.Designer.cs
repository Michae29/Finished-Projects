namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.AGE = new System.Windows.Forms.TextBox();
            this.PatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Modify = new System.Windows.Forms.Button();
            this.ADDButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Allergies = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Med = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.Yellow;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Fname.Location = new System.Drawing.Point(353, 74);
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Size = new System.Drawing.Size(100, 26);
            this.Fname.TabIndex = 2;
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.Yellow;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Lname.Location = new System.Drawing.Point(247, 74);
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Size = new System.Drawing.Size(100, 26);
            this.Lname.TabIndex = 1;
            this.Lname.TextChanged += new System.EventHandler(this.Lname_TextChanged);
            // 
            // AGE
            // 
            this.AGE.BackColor = System.Drawing.Color.Yellow;
            this.AGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AGE.Location = new System.Drawing.Point(459, 74);
            this.AGE.Name = "AGE";
            this.AGE.ReadOnly = true;
            this.AGE.Size = new System.Drawing.Size(100, 26);
            this.AGE.TabIndex = 2;
            this.AGE.TextChanged += new System.EventHandler(this.AGE_TextChanged);
            // 
            // PatientID
            // 
            this.PatientID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PatientID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PatientID.Location = new System.Drawing.Point(141, 79);
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Size = new System.Drawing.Size(100, 20);
            this.PatientID.TabIndex = 3;
            this.PatientID.TextChanged += new System.EventHandler(this.PatientID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Demographics ";
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(139, 412);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(69, 24);
            this.Modify.TabIndex = 7;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // ADDButton
            // 
            this.ADDButton.Location = new System.Drawing.Point(58, 413);
            this.ADDButton.Name = "ADDButton";
            this.ADDButton.Size = new System.Drawing.Size(75, 23);
            this.ADDButton.TabIndex = 8;
            this.ADDButton.Text = "Add";
            this.ADDButton.UseVisualStyleBackColor = true;
            this.ADDButton.Visible = false;
            this.ADDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(139, 383);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(69, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save Changes";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(214, 412);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(69, 23);
            this.Undo.TabIndex = 10;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(289, 412);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(69, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lastname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Firstname";
            // 
            // Allergies
            // 
            this.Allergies.Location = new System.Drawing.Point(471, 409);
            this.Allergies.Name = "Allergies";
            this.Allergies.Size = new System.Drawing.Size(88, 26);
            this.Allergies.TabIndex = 15;
            this.Allergies.Text = "Open Allergies";
            this.Allergies.UseVisualStyleBackColor = true;
            this.Allergies.Click += new System.EventHandler(this.Allergies_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(575, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Open Family";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Open Illness";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Med
            // 
            this.Med.Location = new System.Drawing.Point(566, 411);
            this.Med.Name = "Med";
            this.Med.Size = new System.Drawing.Size(84, 23);
            this.Med.TabIndex = 19;
            this.Med.Text = "Open Medical";
            this.Med.UseVisualStyleBackColor = true;
            this.Med.Click += new System.EventHandler(this.Med_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(575, 281);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(87, 23);
            this.Report.TabIndex = 20;
            this.Report.Text = "Create Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Med);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Allergies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ADDButton);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.TextBox PatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button ADDButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Allergies;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Med;
        private System.Windows.Forms.Button Report;
    }
}