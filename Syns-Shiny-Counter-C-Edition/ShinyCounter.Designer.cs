namespace Syns_Shiny_Counter_C_Edition
{
    partial class ShinyCounter
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.graySmi = new System.Windows.Forms.ToolStripMenuItem();
            this.blackSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.githubSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(437, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundSmi});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // backgroundSmi
            // 
            this.backgroundSmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteSmi,
            this.graySmi,
            this.blackSmi});
            this.backgroundSmi.Name = "backgroundSmi";
            this.backgroundSmi.Size = new System.Drawing.Size(138, 22);
            this.backgroundSmi.Text = "Background";
            // 
            // whiteSmi
            // 
            this.whiteSmi.Name = "whiteSmi";
            this.whiteSmi.Size = new System.Drawing.Size(105, 22);
            this.whiteSmi.Text = "White";
            this.whiteSmi.Click += new System.EventHandler(this.whiteSmi_Click);
            // 
            // graySmi
            // 
            this.graySmi.Name = "graySmi";
            this.graySmi.Size = new System.Drawing.Size(105, 22);
            this.graySmi.Text = "Gray";
            this.graySmi.Click += new System.EventHandler(this.graySmi_Click);
            // 
            // blackSmi
            // 
            this.blackSmi.Name = "blackSmi";
            this.blackSmi.Size = new System.Drawing.Size(105, 22);
            this.blackSmi.Text = "Black";
            this.blackSmi.Click += new System.EventHandler(this.blackSmi_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSmi,
            this.githubSmi});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutSmi
            // 
            this.aboutSmi.Name = "aboutSmi";
            this.aboutSmi.Size = new System.Drawing.Size(180, 22);
            this.aboutSmi.Text = "About";
            this.aboutSmi.Click += new System.EventHandler(this.aboutSmi_Click);
            // 
            // githubSmi
            // 
            this.githubSmi.Name = "githubSmi";
            this.githubSmi.Size = new System.Drawing.Size(180, 22);
            this.githubSmi.Text = "Open GitHub Page";
            this.githubSmi.Click += new System.EventHandler(this.githubSmi_Click);
            // 
            // ShinyCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 615);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ShinyCounter";
            this.Text = "Syn\'s Shiny Counter";
            this.Load += new System.EventHandler(this.ShinyCounter_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundSmi;
        private System.Windows.Forms.ToolStripMenuItem whiteSmi;
        private System.Windows.Forms.ToolStripMenuItem graySmi;
        private System.Windows.Forms.ToolStripMenuItem blackSmi;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSmi;
        private System.Windows.Forms.ToolStripMenuItem githubSmi;
    }
}

