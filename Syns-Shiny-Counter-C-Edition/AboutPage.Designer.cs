namespace Syns_Shiny_Counter_C_Edition
{
    partial class AboutPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.githubLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author: Garrett Rose\r\n\r\nDate of creation: 11/13/18";
            // 
            // githubLbl
            // 
            this.githubLbl.AutoSize = true;
            this.githubLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLbl.Location = new System.Drawing.Point(0, 100);
            this.githubLbl.Name = "githubLbl";
            this.githubLbl.Size = new System.Drawing.Size(134, 25);
            this.githubLbl.TabIndex = 1;
            this.githubLbl.TabStop = true;
            this.githubLbl.Text = "GitHub Page";
            this.githubLbl.Click += new System.EventHandler(this.githubLbl_Click);
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.githubLbl);
            this.Controls.Add(this.label1);
            this.Name = "AboutPage";
            this.Text = "AboutPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel githubLbl;
    }
}