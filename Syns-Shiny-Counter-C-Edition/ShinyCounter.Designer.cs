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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShinyCounter));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.customSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.opacitySmi = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.githubSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardSmi = new System.Windows.Forms.ToolStripMenuItem();
            this.methodCombo = new System.Windows.Forms.ToolStripComboBox();
            this.targetCombo = new System.Windows.Forms.ToolStripComboBox();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.NumericUpDown();
            this.doneBtn = new System.Windows.Forms.Button();
            this.targetLbl = new System.Windows.Forms.Label();
            this.oddsLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.progressLbl = new System.Windows.Forms.Label();
            this.customLbl = new System.Windows.Forms.Label();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.doneBtn2 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
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
            this.resetSmi,
            this.customSmi,
            this.opacitySmi,
            this.intervalSmi});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editMenuItem.Text = "&Edit";
            // 
            // resetSmi
            // 
            this.resetSmi.Name = "resetSmi";
            this.resetSmi.Size = new System.Drawing.Size(159, 22);
            this.resetSmi.Text = "Reset to 0";
            this.resetSmi.Click += new System.EventHandler(this.resetSmi_Click);
            // 
            // customSmi
            // 
            this.customSmi.Name = "customSmi";
            this.customSmi.Size = new System.Drawing.Size(159, 22);
            this.customSmi.Text = "Custom value";
            this.customSmi.Click += new System.EventHandler(this.customSmi_Click);
            // 
            // opacitySmi
            // 
            this.opacitySmi.Name = "opacitySmi";
            this.opacitySmi.Size = new System.Drawing.Size(159, 22);
            this.opacitySmi.Text = "Opacity";
            this.opacitySmi.Click += new System.EventHandler(this.opacitySmi_Click);
            // 
            // intervalSmi
            // 
            this.intervalSmi.Name = "intervalSmi";
            this.intervalSmi.Size = new System.Drawing.Size(159, 22);
            this.intervalSmi.Text = "Counter interval";
            this.intervalSmi.Click += new System.EventHandler(this.intervalSmi_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSmi,
            this.githubSmi,
            this.keyboardSmi});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutSmi
            // 
            this.aboutSmi.Name = "aboutSmi";
            this.aboutSmi.Size = new System.Drawing.Size(176, 22);
            this.aboutSmi.Text = "About";
            this.aboutSmi.Click += new System.EventHandler(this.aboutSmi_Click);
            // 
            // githubSmi
            // 
            this.githubSmi.Name = "githubSmi";
            this.githubSmi.Size = new System.Drawing.Size(176, 22);
            this.githubSmi.Text = "Open GitHub Page";
            this.githubSmi.Click += new System.EventHandler(this.githubSmi_Click);
            // 
            // keyboardSmi
            // 
            this.keyboardSmi.Name = "keyboardSmi";
            this.keyboardSmi.Size = new System.Drawing.Size(176, 22);
            this.keyboardSmi.Text = "Keyboard shortcuts";
            this.keyboardSmi.Click += new System.EventHandler(this.keyboardSmi_Click);
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
            "Chain Fishing",
            "Catch Combo (With lure)",
            "Catch Combo (No lure)",
            "Hordes"});
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
            this.minusBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(109, 334);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(79, 49);
            this.minusBtn.TabIndex = 3;
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
            this.plusBtn.TabIndex = 2;
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
            // progressLbl
            // 
            this.progressLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.progressLbl.Location = new System.Drawing.Point(51, 386);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(357, 80);
            this.progressLbl.TabIndex = 8;
            this.progressLbl.Text = "Progress message";
            this.progressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customLbl
            // 
            this.customLbl.AutoSize = true;
            this.customLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLbl.Location = new System.Drawing.Point(12, 258);
            this.customLbl.Name = "customLbl";
            this.customLbl.Size = new System.Drawing.Size(441, 21);
            this.customLbl.TabIndex = 9;
            this.customLbl.Text = "Enter a value into the encounters field, then press \'Done\'";
            this.customLbl.Visible = false;
            // 
            // opacityBar
            // 
            this.opacityBar.Location = new System.Drawing.Point(351, 591);
            this.opacityBar.Minimum = 1;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(104, 45);
            this.opacityBar.TabIndex = 10;
            this.opacityBar.Value = 10;
            this.opacityBar.Visible = false;
            this.opacityBar.ValueChanged += new System.EventHandler(this.opacityBar_ValueChanged);
            // 
            // doneBtn2
            // 
            this.doneBtn2.Location = new System.Drawing.Point(368, 562);
            this.doneBtn2.Name = "doneBtn2";
            this.doneBtn2.Size = new System.Drawing.Size(75, 23);
            this.doneBtn2.TabIndex = 11;
            this.doneBtn2.Text = "Done";
            this.doneBtn2.UseVisualStyleBackColor = true;
            this.doneBtn2.Visible = false;
            this.doneBtn2.Click += new System.EventHandler(this.doneBtn2_Click);
            // 
            // ShinyCounter
            // 
            this.AcceptButton = this.plusBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.minusBtn;
            this.ClientSize = new System.Drawing.Size(467, 648);
            this.Controls.Add(this.doneBtn2);
            this.Controls.Add(this.opacityBar);
            this.Controls.Add(this.customLbl);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.oddsLbl);
            this.Controls.Add(this.targetLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "ShinyCounter";
            this.Text = "Syn\'s Shiny Counter";
            this.Load += new System.EventHandler(this.ShinyCounter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShinyCounter_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
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
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.Label customLbl;
        private System.Windows.Forms.ToolStripMenuItem keyboardSmi;
        private System.Windows.Forms.TrackBar opacityBar;
        private System.Windows.Forms.ToolStripMenuItem opacitySmi;
        private System.Windows.Forms.Button doneBtn2;
        private System.Windows.Forms.ToolStripMenuItem intervalSmi;
    }
}

