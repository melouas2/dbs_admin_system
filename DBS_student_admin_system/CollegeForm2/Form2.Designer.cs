namespace CollegeForm2
{
    partial class FormCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompare));
            this.lvwCompare1 = new System.Windows.Forms.ListView();
            this.lvwCompare2 = new System.Windows.Forms.ListView();
            this.lvwCompare3 = new System.Windows.Forms.ListView();
            this.lvwCompare4 = new System.Windows.Forms.ListView();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblCompare1 = new System.Windows.Forms.Label();
            this.btnCompare2 = new System.Windows.Forms.Button();
            this.lblCompare2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwCompare1
            // 
            this.lvwCompare1.Location = new System.Drawing.Point(41, 12);
            this.lvwCompare1.Name = "lvwCompare1";
            this.lvwCompare1.Size = new System.Drawing.Size(520, 70);
            this.lvwCompare1.TabIndex = 0;
            this.lvwCompare1.UseCompatibleStateImageBehavior = false;
            this.lvwCompare1.View = System.Windows.Forms.View.Details;
            this.lvwCompare1.SelectedIndexChanged += new System.EventHandler(this.lvwCompare1_SelectedIndexChanged);
            // 
            // lvwCompare2
            // 
            this.lvwCompare2.Location = new System.Drawing.Point(41, 79);
            this.lvwCompare2.Name = "lvwCompare2";
            this.lvwCompare2.Size = new System.Drawing.Size(520, 80);
            this.lvwCompare2.TabIndex = 1;
            this.lvwCompare2.UseCompatibleStateImageBehavior = false;
            this.lvwCompare2.View = System.Windows.Forms.View.Details;
            // 
            // lvwCompare3
            // 
            this.lvwCompare3.Location = new System.Drawing.Point(41, 203);
            this.lvwCompare3.Name = "lvwCompare3";
            this.lvwCompare3.Size = new System.Drawing.Size(520, 84);
            this.lvwCompare3.TabIndex = 2;
            this.lvwCompare3.UseCompatibleStateImageBehavior = false;
            this.lvwCompare3.View = System.Windows.Forms.View.Details;
            // 
            // lvwCompare4
            // 
            this.lvwCompare4.Location = new System.Drawing.Point(41, 285);
            this.lvwCompare4.Name = "lvwCompare4";
            this.lvwCompare4.Size = new System.Drawing.Size(520, 78);
            this.lvwCompare4.TabIndex = 3;
            this.lvwCompare4.UseCompatibleStateImageBehavior = false;
            this.lvwCompare4.View = System.Windows.Forms.View.Details;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(41, 165);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblCompare1
            // 
            this.lblCompare1.Location = new System.Drawing.Point(132, 165);
            this.lblCompare1.Name = "lblCompare1";
            this.lblCompare1.Size = new System.Drawing.Size(429, 23);
            this.lblCompare1.TabIndex = 5;
            // 
            // btnCompare2
            // 
            this.btnCompare2.Location = new System.Drawing.Point(41, 369);
            this.btnCompare2.Name = "btnCompare2";
            this.btnCompare2.Size = new System.Drawing.Size(75, 23);
            this.btnCompare2.TabIndex = 6;
            this.btnCompare2.Text = "Compare";
            this.btnCompare2.UseVisualStyleBackColor = true;
            this.btnCompare2.Click += new System.EventHandler(this.btnCompare2_Click);
            // 
            // lblCompare2
            // 
            this.lblCompare2.Location = new System.Drawing.Point(132, 369);
            this.lblCompare2.Name = "lblCompare2";
            this.lblCompare2.Size = new System.Drawing.Size(429, 23);
            this.lblCompare2.TabIndex = 7;
            // 
            // FormCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(611, 445);
            this.Controls.Add(this.lblCompare2);
            this.Controls.Add(this.btnCompare2);
            this.Controls.Add(this.lblCompare1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lvwCompare4);
            this.Controls.Add(this.lvwCompare3);
            this.Controls.Add(this.lvwCompare2);
            this.Controls.Add(this.lvwCompare1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompare";
            this.Text = "Compare test data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwCompare1;
        private System.Windows.Forms.ListView lvwCompare2;
        private System.Windows.Forms.ListView lvwCompare3;
        private System.Windows.Forms.ListView lvwCompare4;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblCompare1;
        private System.Windows.Forms.Button btnCompare2;
        private System.Windows.Forms.Label lblCompare2;
    }
}