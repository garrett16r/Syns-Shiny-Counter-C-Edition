using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syns_Shiny_Counter_C_Edition
{
    public partial class ShinyCounter : Form
    {
        public ShinyCounter()
        {
            InitializeComponent();
        }

        private void ShinyCounter_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            menuStrip.BackColor = Color.DarkGray;
        }

        private void whiteSmi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GhostWhite;
            menuStrip.BackColor = Color.GhostWhite;
            editMenuItem.ForeColor = Color.Black;
            helpMenuItem.ForeColor = Color.Black;
        }

        private void graySmi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            menuStrip.BackColor = Color.DarkGray;
            editMenuItem.ForeColor = Color.Black;
            helpMenuItem.ForeColor = Color.Black;
        }

        private void blackSmi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            menuStrip.BackColor = Color.Black;
            editMenuItem.ForeColor = Color.White;
            helpMenuItem.ForeColor = Color.White;
        }

        private void aboutSmi_Click(object sender, EventArgs e)
        {
            AboutPage abp = new AboutPage();
            abp.ShowDialog();
        }

        private void githubSmi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Syntthetix/Syns-Shiny-Counter-C-Edition");
        }
    }
}
