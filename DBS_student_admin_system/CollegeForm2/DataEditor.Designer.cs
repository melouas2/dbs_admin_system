namespace CollegeForm2
{
    partial class DataEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEditor));
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lvwDisplay = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.txtStuLName = new System.Windows.Forms.TextBox();
            this.txtStuFName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lvwDisplay2 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.txtTeaEmail = new System.Windows.Forms.TextBox();
            this.txtTeaPhone = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTeaLName = new System.Windows.Forms.TextBox();
            this.txtTeaFName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(493, 324);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 23);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove Person";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(172, 321);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(493, 527);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 23);
            this.btnDisplay.TabIndex = 28;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 321);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(86, 20);
            this.txtSearch.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(33, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 23);
            this.label13.TabIndex = 37;
            // 
            // lvwDisplay
            // 
            this.lvwDisplay.GridLines = true;
            this.lvwDisplay.Location = new System.Drawing.Point(25, 361);
            this.lvwDisplay.Name = "lvwDisplay";
            this.lvwDisplay.Size = new System.Drawing.Size(565, 76);
            this.lvwDisplay.TabIndex = 38;
            this.lvwDisplay.UseCompatibleStateImageBehavior = false;
            this.lvwDisplay.View = System.Windows.Forms.View.Details;
            this.lvwDisplay.SelectedIndexChanged += new System.EventHandler(this.lvwDisplay_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddStu);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.txtStuPhone);
            this.groupBox1.Controls.Add(this.txtStuEmail);
            this.groupBox1.Controls.Add(this.txtStuLName);
            this.groupBox1.Controls.Add(this.txtStuFName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 280);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Last Name";
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(85, 241);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(100, 23);
            this.btnAddStu.TabIndex = 47;
            this.btnAddStu.Text = "Add Student";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click_1);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Undergraduate",
            "Postgraduate"});
            this.cmbStatus.Location = new System.Drawing.Point(85, 53);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 46;
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(85, 196);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(100, 20);
            this.txtStuPhone.TabIndex = 45;
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(85, 162);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(100, 20);
            this.txtStuEmail.TabIndex = 44;
            // 
            // txtStuLName
            // 
            this.txtStuLName.Location = new System.Drawing.Point(85, 126);
            this.txtStuLName.Name = "txtStuLName";
            this.txtStuLName.Size = new System.Drawing.Size(100, 20);
            this.txtStuLName.TabIndex = 43;
            // 
            // txtStuFName
            // 
            this.txtStuFName.Location = new System.Drawing.Point(85, 90);
            this.txtStuFName.Name = "txtStuFName";
            this.txtStuFName.Size = new System.Drawing.Size(100, 20);
            this.txtStuFName.TabIndex = 42;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(85, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Status";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(55, 13);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "StudentID";
            // 
            // lvwDisplay2
            // 
            this.lvwDisplay2.Location = new System.Drawing.Point(25, 433);
            this.lvwDisplay2.Name = "lvwDisplay2";
            this.lvwDisplay2.Size = new System.Drawing.Size(565, 73);
            this.lvwDisplay2.TabIndex = 40;
            this.lvwDisplay2.UseCompatibleStateImageBehavior = false;
            this.lvwDisplay2.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTeacher);
            this.groupBox2.Controls.Add(this.txtTeaEmail);
            this.groupBox2.Controls.Add(this.txtTeaPhone);
            this.groupBox2.Controls.Add(this.txtSalary);
            this.groupBox2.Controls.Add(this.txtSubject);
            this.groupBox2.Controls.Add(this.txtTeaLName);
            this.groupBox2.Controls.Add(this.txtTeaFName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 280);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Teacher";
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(78, 238);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(100, 23);
            this.btnTeacher.TabIndex = 45;
            this.btnTeacher.Text = "Add Teacher";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click_1);
            // 
            // txtTeaEmail
            // 
            this.txtTeaEmail.Location = new System.Drawing.Point(79, 159);
            this.txtTeaEmail.Name = "txtTeaEmail";
            this.txtTeaEmail.Size = new System.Drawing.Size(99, 20);
            this.txtTeaEmail.TabIndex = 44;
            // 
            // txtTeaPhone
            // 
            this.txtTeaPhone.Location = new System.Drawing.Point(78, 193);
            this.txtTeaPhone.Name = "txtTeaPhone";
            this.txtTeaPhone.Size = new System.Drawing.Size(99, 20);
            this.txtTeaPhone.TabIndex = 43;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(79, 123);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(99, 20);
            this.txtSalary.TabIndex = 42;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(79, 87);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(99, 20);
            this.txtSubject.TabIndex = 41;
            // 
            // txtTeaLName
            // 
            this.txtTeaLName.Location = new System.Drawing.Point(79, 51);
            this.txtTeaLName.Name = "txtTeaLName";
            this.txtTeaLName.Size = new System.Drawing.Size(99, 20);
            this.txtTeaLName.TabIndex = 40;
            // 
            // txtTeaFName
            // 
            this.txtTeaFName.Location = new System.Drawing.Point(78, 21);
            this.txtTeaFName.Name = "txtTeaFName";
            this.txtTeaFName.Size = new System.Drawing.Size(100, 20);
            this.txtTeaFName.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Subject";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "First Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(390, 324);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(86, 20);
            this.txtPhone.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(306, 328);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Phone Number";
            // 
            // DataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(611, 630);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvwDisplay2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwDisplay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataEditor";
            this.Text = "DataEditor";
            this.Load += new System.EventHandler(this.DataEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvwDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.TextBox txtStuLName;
        private System.Windows.Forms.TextBox txtStuFName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListView lvwDisplay2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.TextBox txtTeaEmail;
        private System.Windows.Forms.TextBox txtTeaPhone;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTeaLName;
        private System.Windows.Forms.TextBox txtTeaFName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}