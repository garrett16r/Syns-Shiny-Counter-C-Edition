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

        public int count = 0;

        public ShinyCounter()
        {
            InitializeComponent();
        }

        private void ShinyCounter_Load(object sender, EventArgs e)
        {
            fillPokemonList();
            load();
            countBox.Value = count;
            saveBtn.Visible = false;

            if (!targetCombo.Text.Equals("Select target..."))
            {
                targetLbl.Text = "Hunting for: " + targetCombo.Text;
            }            
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
            saveBtn.Visible = false;

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

        // Obtains the max odds for the current hunting method
        public int getOdds()
        {
            int odds = 0;

            // Contains the 34 different odds that you go through in a radar hunt
            // with their respective encounter numbers
            int[] radarOddsXY = { 4096, 4096, 3855, 3855, 3641, 3641, 3449, 3449, 3277, 3277, 3121, 2979, 2849, 2849, 2731,
                2621, 2521, 2427, 2341, 2185, 2114, 1986, 1928, 1820, 1680, 1598, 1489, 1394, 1311, 1192, 1092, 993,
                898, 799, 697, 601, 500, 400, 301, 200 };

            int[] radarOddsDPP = { 8192, 8192, 7282, 7282, 7282, 7282, 6554, 6554, 6554, 5958, 5958, 5958, 5461, 5461, 5041,
                5041, 4681, 4681, 4369, 4096, 4096, 3855, 3641, 3449, 3277, 2979, 2849, 2621, 2427, 2185, 1986, 1820,
                1598, 1394, 1192, 993, 799, 601, 400, 200 };

            int[] chainFishOdds = { 1336, 1336, 820, 586, 456, 373, 316, 274, 241, 216, 196, 179, 164, 152, 142, 133, 125,
                118, 111, 106, 100 };

            if (methodCombo.Text.Equals("Poke Radar (XY)"))
            {

                if (count > 0 && count < 40)
                {
                    odds = radarOddsXY[count - 1];
                }
                else if (count == 0)
                {
                    odds = 4096;
                }
                else
                {
                    odds = 200;
                }
            }

            if (methodCombo.Text.Equals("Poke Radar (DPP)"))
            {

                if (count > 0 && count < 40)
                {
                    odds = radarOddsDPP[count - 1];
                }
                else if (count == 0)
                {
                    odds = 8192;
                }
                else
                {
                    odds = 200;
                }
            }

            if (methodCombo.Text.Equals("Chain Fishing"))
            {

                if (count > 0 && count < 20)
                {
                    odds = chainFishOdds[count - 1];
                }
                else if (count == 0)
                {
                    odds = 4096;
                }
                else
                {
                    odds = 100;
                }
            }

            if (methodCombo.Text.Equals("RE's (Pre Gen 6)") || methodCombo.Text.Equals("Soft Resets (Pre Gen 6)"))
            {
                odds = 8192;
            }
            else if (methodCombo.Text.Equals("RE's (Gen 6+)") || methodCombo.Text.Equals("Soft Resets (Gen 6+)"))
            {
                odds = 4096;
            }

            return odds;
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
            countBox.ReadOnly = false;
            doneBtn.Visible = true;
            MessageBox.Show("Enter a value into the encounters field, then press 'Done'");
        }

        private void resetSmi_Click(object sender, EventArgs e)
        {
            count = 0;
            countBox.Value = count;
        }

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
            count = (int)countBox.Value;
            save();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            count = (int)countBox.Value;
            save();

            countBox.ReadOnly = true;
            doneBtn.Visible = false;
        }

        private void targetCombo_TextChanged(object sender, EventArgs e)
        {
            targetLbl.Text = "Hunting for: " + targetCombo.Text;
            saveBtn.Visible = true;
        }

        private void methodCombo_TextChanged(object sender, EventArgs e)
        {
            oddsLbl.Text = ("Your odds: 1/" + getOdds());
            saveBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            save();
            saveBtn.Visible = false;
        }
    }
}
