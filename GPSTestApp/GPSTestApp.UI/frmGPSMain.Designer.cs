namespace GPSTestApp.UI
{
    partial class frmGPSMain
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(87, 231);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblLat
            // 
            this.lblLat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLat.Location = new System.Drawing.Point(69, 16);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(118, 23);
            this.lblLat.TabIndex = 1;
            this.lblLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLong
            // 
            this.lblLong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLong.Location = new System.Drawing.Point(69, 43);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(118, 23);
            this.lblLong.TabIndex = 2;
            this.lblLong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longitude:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblLong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(278, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblAlt
            // 
            this.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlt.Location = new System.Drawing.Point(106, 129);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(118, 23);
            this.lblAlt.TabIndex = 7;
            this.lblAlt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpeed
            // 
            this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpeed.Location = new System.Drawing.Point(106, 175);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(118, 23);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccuracy.Location = new System.Drawing.Point(106, 152);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(118, 23);
            this.lblAccuracy.TabIndex = 9;
            this.lblAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse
            // 
            this.lblCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse.Location = new System.Drawing.Point(106, 198);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(118, 23);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Location = new System.Drawing.Point(106, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 23);
            this.lblTime.TabIndex = 11;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmGPSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 386);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGo);
            this.Name = "frmGPSMain";
            this.Text = "GPS Test App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblTime;
    }
}

