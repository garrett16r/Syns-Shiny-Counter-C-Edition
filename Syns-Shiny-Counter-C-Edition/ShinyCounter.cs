using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Syns_Shiny_Counter_C_Edition
{
    public partial class ShinyCounter : Form
    {

        int count = 0;

        public ShinyCounter()
        {
            InitializeComponent();
        }

        private void ShinyCounter_Load(object sender, EventArgs e)
        {
            fillPokemonList();
            load();
            countBox.Value = count;
        }

        // Fill the targetCombo list with all pokemon
        public void fillPokemonList()
        {
            List<string> pokemonList = new List<string>();
            using (StreamReader sr = new StreamReader("pokemonlist.txt"))
            {
                string token;

                while ((token = sr.ReadLine()) != null)
                {
                    pokemonList.Add(token);
                }
            }

            foreach (string s in pokemonList)
            {
                targetCombo.Items.Add(s);
            }
        }

        public void save()
        {
            using (StreamWriter sw = new StreamWriter("count.txt"))
            {
                sw.WriteLine(count.ToString());
            }

            using (StreamWriter sw = new StreamWriter("targetmethod.txt"))
            {
                sw.WriteLine(targetCombo.Text);
                sw.WriteLine(methodCombo.Text);
            }
        }

        public void load()
        {
            using (StreamReader sr = new StreamReader("count.txt"))
            {
                count = int.Parse(sr.ReadLine());
            }

            using (StreamReader sr = new StreamReader("targetmethod.txt"))
            {
                targetCombo.Text = sr.ReadLine();
                methodCombo.Text = sr.ReadLine();
            }
        }

        // Change background to white
        private void whiteSmi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GhostWhite;
            menuStrip.BackColor = Color.GhostWhite;
            editMenuItem.ForeColor = Color.Black;
            helpMenuItem.ForeColor = Color.Black;
        }

        // Change background to gray
        private void graySmi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            menuStrip.BackColor = Color.DarkGray;
            editMenuItem.ForeColor = Color.Black;
            helpMenuItem.ForeColor = Color.Black;
        }

        // Change background to black
        private void blackSmi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            menuStrip.BackColor = Color.Black;
            editMenuItem.ForeColor = Color.White;
            helpMenuItem.ForeColor = Color.White;
        }

        // About page button
        private void aboutSmi_Click(object sender, EventArgs e)
        {
            AboutPage abp = new AboutPage();
            abp.ShowDialog();
        }

        // Open GitHub Page button
        private void githubSmi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Syntthetix/Syns-Shiny-Counter-C-Edition");
        }

        private void customSmi_Click(object sender, EventArgs e)
        {

        }

        private void resetSmi_Click(object sender, EventArgs e)
        {
            count = 0;
            countBox.Value = count;
        }

        // Increase counter by clicking on label
        

        private void minusBtn_Click(object sender, EventArgs e)
        {
            count--;
            countBox.Value = count;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            count++;
            countBox.Value = count;
        }
        
        // Save data whenever count is updated
        private void countBox_ValueChanged(object sender, EventArgs e)
        {
            save();
        }
    }
}
