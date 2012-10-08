namespace Novak.StudentMaintenance.UI
{
    partial class frmMaintenance
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
            this.btnMakePerson = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.btnMakeStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakePerson
            // 
            this.btnMakePerson.Location = new System.Drawing.Point(12, 64);
            this.btnMakePerson.Name = "btnMakePerson";
            this.btnMakePerson.Size = new System.Drawing.Size(100, 23);
            this.btnMakePerson.TabIndex = 0;
            this.btnMakePerson.Text = "Make Person";
            this.btnMakePerson.UseVisualStyleBackColor = true;
            this.btnMakePerson.Click += new System.EventHandler(this.btnMakePerson_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(12, 12);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(12, 38);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(12, 100);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(0, 13);
            this.lblFullname.TabIndex = 3;
            // 
            // btnMakeStudent
            // 
            this.btnMakeStudent.Location = new System.Drawing.Point(118, 64);
            this.btnMakeStudent.Name = "btnMakeStudent";
            this.btnMakeStudent.Size = new System.Drawing.Size(100, 23);
            this.btnMakeStudent.TabIndex = 4;
            this.btnMakeStudent.Text = "Make Student";
            this.btnMakeStudent.UseVisualStyleBackColor = true;
            this.btnMakeStudent.Click += new System.EventHandler(this.btnMakeStudent_Click);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMakeStudent);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnMakePerson);
            this.Name = "frmMaintenance";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakePerson;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Button btnMakeStudent;
    }
}

