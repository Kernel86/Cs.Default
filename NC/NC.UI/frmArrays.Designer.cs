namespace NC.UI
{
    partial class frmArrays
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
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnArrayFor = new System.Windows.Forms.Button();
            this.btn2dArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(39, 35);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(75, 23);
            this.btnCreateArray.TabIndex = 0;
            this.btnCreateArray.Text = "1 Dim Array";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(212, 35);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(120, 95);
            this.lstOutput.TabIndex = 1;
            // 
            // btnArrayFor
            // 
            this.btnArrayFor.Location = new System.Drawing.Point(39, 64);
            this.btnArrayFor.Name = "btnArrayFor";
            this.btnArrayFor.Size = new System.Drawing.Size(75, 23);
            this.btnArrayFor.TabIndex = 2;
            this.btnArrayFor.Text = "1 Dim Array";
            this.btnArrayFor.UseVisualStyleBackColor = true;
            this.btnArrayFor.Click += new System.EventHandler(this.btnArrayFor_Click);
            // 
            // btn2dArray
            // 
            this.btn2dArray.Location = new System.Drawing.Point(39, 93);
            this.btn2dArray.Name = "btn2dArray";
            this.btn2dArray.Size = new System.Drawing.Size(75, 23);
            this.btn2dArray.TabIndex = 3;
            this.btn2dArray.Text = "1 Dim Array";
            this.btn2dArray.UseVisualStyleBackColor = true;
            this.btn2dArray.Click += new System.EventHandler(this.btn2dArray_Click);
            // 
            // frmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 236);
            this.Controls.Add(this.btn2dArray);
            this.Controls.Add(this.btnArrayFor);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnCreateArray);
            this.Name = "frmArrays";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnArrayFor;
        private System.Windows.Forms.Button btn2dArray;
    }
}

