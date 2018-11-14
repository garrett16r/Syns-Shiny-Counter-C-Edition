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
            this.resetSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.customSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.githubSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.methodCombo = new System.Windows.Forms.ToolStripComboBox();
            this.targetCombo = new System.Windows.Forms.ToolStripComboBox();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.NumericUpDown();
            this.doneBtn = new System.Windows.Forms.Button();
            this.targetLbl = new System.Windows.Forms.Label();
            this.oddsLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItem,
            this.helpMenuItem,
            this.methodCombo,
            this.targetCombo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(467, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundSmi,
            this.resetSmi,
            this.customSmi});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editMenuItem.Text = "Edit";
            // 
            // backgroundSmi
            // 
            this.backgroundSmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteSmi,
            this.graySmi,
            this.blackSmi});
            this.backgroundSmi.Name = "backgroundSmi";
            this.backgroundSmi.Size = new System.Drawing.Size(147, 22);
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
            // resetSmi
            // 
            this.resetSmi.Name = "resetSmi";
            this.resetSmi.Size = new System.Drawing.Size(147, 22);
            this.resetSmi.Text = "Reset to 0";
            this.resetSmi.Click += new System.EventHandler(this.resetSmi_Click);
            // 
            // customSmi
            // 
            this.customSmi.Name = "customSmi";
            this.customSmi.Size = new System.Drawing.Size(147, 22);
            this.customSmi.Text = "Custom value";
            this.customSmi.Click += new System.EventHandler(this.customSmi_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSmi,
            this.githubSmi});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutSmi
            // 
            this.aboutSmi.Name = "aboutSmi";
            this.aboutSmi.Size = new System.Drawing.Size(173, 22);
            this.aboutSmi.Text = "About";
            this.aboutSmi.Click += new System.EventHandler(this.aboutSmi_Click);
            // 
            // githubSmi
            // 
            this.githubSmi.Name = "githubSmi";
            this.githubSmi.Size = new System.Drawing.Size(173, 22);
            this.githubSmi.Text = "Open GitHub Page";
            this.githubSmi.Click += new System.EventHandler(this.githubSmi_Click);
            // 
            // methodCombo
            // 
            this.methodCombo.Items.AddRange(new object[] {
            "RE\'s (Pre Gen 6)",
            "RE\'s (Gen 6+)",
            "Soft Resets (Pre Gen 6)",
            "Soft Resets (Gen 6+)",
            "Poke Radar (XY)",
            "Poke Radar (DPP)",
            "Chain Fishing"});
            this.methodCombo.Name = "methodCombo";
            this.methodCombo.Size = new System.Drawing.Size(145, 23);
            this.methodCombo.Text = "Select method...";
            this.methodCombo.ToolTipText = "Select your shiny hunting method here.";
            this.methodCombo.TextChanged += new System.EventHandler(this.methodCombo_TextChanged);
            // 
            // targetCombo
            // 
            this.targetCombo.Name = "targetCombo";
            this.targetCombo.Size = new System.Drawing.Size(145, 23);
            this.targetCombo.Text = "Select target...";
            this.targetCombo.TextChanged += new System.EventHandler(this.targetCombo_TextChanged);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(109, 334);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(79, 49);
            this.minusBtn.TabIndex = 2;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(265, 334);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(79, 49);
            this.plusBtn.TabIndex = 3;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // countBox
            // 
            this.countBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countBox.Font = new System.Drawing.Font("SAO UI", 65.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.countBox.Location = new System.Drawing.Point(135, 107);
            this.countBox.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.countBox.Name = "countBox";
            this.countBox.ReadOnly = true;
            this.countBox.Size = new System.Drawing.Size(182, 108);
            this.countBox.TabIndex = 1;
            this.countBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countBox.ValueChanged += new System.EventHandler(this.countBox_ValueChanged);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(181, 221);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Visible = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // targetLbl
            // 
            this.targetLbl.AutoSize = true;
            this.targetLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.targetLbl.Location = new System.Drawing.Point(12, 583);
            this.targetLbl.Name = "targetLbl";
            this.targetLbl.Size = new System.Drawing.Size(186, 28);
            this.targetLbl.TabIndex = 5;
            this.targetLbl.Text = "Hunting for: None";
            // 
            // oddsLbl
            // 
            this.oddsLbl.AutoSize = true;
            this.oddsLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oddsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.oddsLbl.Location = new System.Drawing.Point(12, 611);
            this.oddsLbl.Name = "oddsLbl";
            this.oddsLbl.Size = new System.Drawing.Size(269, 28);
            this.oddsLbl.TabIndex = 6;
            this.oddsLbl.Text = "Your odds: Select a method";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(197, 30);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ShinyCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 648);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.oddsLbl);
            this.Controls.Add(this.targetLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ShinyCounter";
            this.Text = "Syn\'s Shiny Counter";
            this.Load += new System.EventHandler(this.ShinyCounter_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem resetSmi;
        private System.Windows.Forms.ToolStripMenuItem customSmi;
        private System.Windows.Forms.ToolStripComboBox methodCombo;
        private System.Windows.Forms.ToolStripComboBox targetCombo;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        public System.Windows.Forms.NumericUpDown countBox;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label targetLbl;
        private System.Windows.Forms.Label oddsLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}

