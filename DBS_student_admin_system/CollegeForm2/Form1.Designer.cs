namespace CollegeForm2
{
    partial class College
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(College));
            this.btnData = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(34, 41);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(127, 23);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "Data Editor";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(216, 41);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(124, 23);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare Test Data";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.button2_Click);
            // 
            // College
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(385, 100);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "College";
            this.Text = "DBS Data Manager 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnCompare;
    }
}

