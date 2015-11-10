namespace GitDemoProject
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(195, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Hello World from Muni and Gin ! What ?";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(45, 82);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(119, 13);
            this.lblNew.TabIndex = 1;
            this.lblNew.Text = "Hello World from Jason.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(89, 129);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 33);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button btnSubmit;
    }
}

