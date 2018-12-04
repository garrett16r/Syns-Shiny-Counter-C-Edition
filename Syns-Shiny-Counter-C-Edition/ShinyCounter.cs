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

        public string HOME_DIR = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public string SAVE_DIR = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/Syns Shiny Counter C# Edition/save";
        public string RES_DIR = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/Syns Shiny Counter C# Edition/res";
        public int count = 0;
        public string target = "";
        public string method = "";
        public int oddsMax = 8192;

        public ShinyCounter()
        {
            InitializeComponent();
        }

        // Any code in this method immediately runs on startup
        private void ShinyCounter_Load(object sender, EventArgs e)
        {            
            createFilesDirectories();
            fillPokemonList();
            //load();
            countBox.Value = count;
            progressLbl.Text = getProgressMessage();
            saveBtn.Visible = false;

            if (!targetCombo.Text.Equals("Select target..."))
            {
                targetLbl.Text = "Hunting for: " + targetCombo.Text;
            }
        }

        // Create the file directories for the save files and resource files
        public void createFilesDirectories()
        {
            if (!System.IO.Directory.Exists(HOME_DIR + "/Documents/Syns Shiny Counter C# Edition"))
            {
                System.IO.Directory.CreateDirectory(SAVE_DIR);
                System.IO.Directory.CreateDirectory(RES_DIR);

                // Create a file for the pokemon list, then fill it with the pokemonlist string resource
                System.IO.File.CreateText(RES_DIR + "/pokemonlist.txt").Close();
                System.IO.File.WriteAllText(RES_DIR + "/pokemonlist.txt", Properties.Resources.pokemonlist);
            }
            else
            {
                load();
            }
        }

        // Fill the targetCombo list with all pokemon
        public void fillPokemonList()
        {
            List<string> pokemonList = new List<string>();

            using (StreamReader sr = new StreamReader(RES_DIR + "/pokemonlist.txt"))
            {
                string token;

                while ((token = sr.ReadLine()) != null)
                {
                    pokemonList.Add(token);
                }
                sr.Close();
            }

            foreach (string s in pokemonList)
            {
                targetCombo.Items.Add(s);
            }
        }

        // Save all data
        public void save()
        {
            saveBtn.Visible = false;

            using (StreamWriter sw = new StreamWriter(SAVE_DIR + "/count.txt"))
            {
                sw.WriteLine(count.ToString());
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(SAVE_DIR + "/data.txt"))
            {
                sw.WriteLine(targetCombo.Text);
                sw.WriteLine(methodCombo.Text);
                sw.WriteLine(this.Opacity);
                sw.Close();
            }
        }

        // Load all data on launch
        public void load()
        {
            using (StreamReader sr = new StreamReader(SAVE_DIR + "/count.txt"))
            {
                try
                {
                    count = int.Parse(sr.ReadLine());
                    sr.Close();
                }
                catch (Exception) { }
            }

            using (StreamReader sr = new StreamReader(SAVE_DIR + "/data.txt"))
            {
                target = sr.ReadLine();
                method = sr.ReadLine();
                this.Opacity = double.Parse(sr.ReadLine());
                opacityBar.Value = (int)(this.Opacity * 10);
                targetCombo.Text = target;
                methodCombo.Text = method;
                sr.Close();
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

        // Obtain a progress message based on the current number of encounters compared to the max odds for the current method
        public string getProgressMessage()
        {
            List<String> msg = new List<String>();
            String message = "";
            msg.Add("You've got a ways to go...");
            msg.Add("One quarter of the way to odds!");
            msg.Add("Half way to odds!");
            msg.Add("Three quarters of the way!");
            msg.Add("You should get " + target + " really soon!");
            msg.Add("You better not stop the hunt now.");
            msg.Add("Better get that chain going.");
            msg.Add("It's a miracle you haven't broken your chain.");

            if (!method.Equals("Poke Radar (XY)") && !method.Equals("Poke Radar (DPP)")
                    && !method.Equals("Chain Fishing"))
            {
                if (count < (oddsMax / 4))
                {
                    message = msg[0];
                }
                else if (count < (oddsMax / 2))
                {
                    message = msg[1];
                }
                else if (count < ((double)oddsMax * (double)0.75))
                {
                    message = msg[2];
                }
                else if (count < oddsMax)
                {
                    message = msg[3];
                }
                else if (count >= oddsMax && count <= oddsMax + 200)
                {
                    message = msg[4];
                }
                else if (count > oddsMax + 200)
                {
                    message = msg[5];
                }
            }
            else if (!method.Equals("Chain Fishing"))
            {
                if (count < 10)
                {
                    message = msg[6];
                }
                else if (count < 20)
                {
                    message = msg[1];
                }
                else if (count < 30)
                {
                    message = msg[2];
                }
                else if (count < 40)
                {
                    message = msg[3];
                }
                else
                {
                    message = "You better reset like there's no tomorrow (" + (count - 40) + " resets)";
                }
            }
            else if (method.Equals("Chain Fishing"))
            {
                if (count < 5)
                {
                    message = msg[6];
                }
                else if (count < 10)
                {
                    message = msg[1];
                }
                else if (count < 15)
                {
                    message = msg[2];
                }
                else if (count < 20)
                {
                    message = msg[3];
                }
                else if (count >= 20 && count < 100)
                {
                    message = msg[4];
                }
                else
                {
                    message = msg[5];
                }
            }

            return message;
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
            customLbl.Visible = true;
            //MessageBox.Show("Enter a value into the encounters field, then press 'Done'");
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            count = (int)countBox.Value; save();

            countBox.ReadOnly = true;
            doneBtn.Visible = false;
            customLbl.Visible = false;
        }

        private void resetSmi_Click(object sender, EventArgs e)
        {
            count = 0;
            countBox.Value = count;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                countBox.Value = count;
                countBox.Focus();
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            count++;
            countBox.Value = count;
            countBox.Focus();
        }

        // Save data whenever count is updated
        private void countBox_ValueChanged(object sender, EventArgs e)
        {
            count = (int)countBox.Value;
            progressLbl.Text = getProgressMessage();
            save();
        }

        private void targetCombo_TextChanged(object sender, EventArgs e)
        {
            targetLbl.Text = "Hunting for: " + targetCombo.Text;
            saveBtn.Visible = true;
        }

        private void methodCombo_TextChanged(object sender, EventArgs e)
        {
            oddsMax = getOdds();
            oddsLbl.Text = ("Your odds: 1/" + oddsMax);
            progressLbl.Text = getProgressMessage();
            saveBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            save();
            saveBtn.Visible = false;
        }

        private void keyboardSmi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Up arrow - Increase counter\n" +
                "Down arrow - Decrease counter\n" +
                "F1 - Reset counter to 0\n" +
                "F2 - Set a custom value\n" +
                "F5 - Show this screen");
        }

        private void ShinyCounter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                customSmi_Click(null, null);
            }
            else if (e.KeyCode == Keys.F1)
            {
                resetSmi_Click(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                keyboardSmi_Click(null, null);
            }
        }

        private void opacitySmi_Click(object sender, EventArgs e)
        {
            opacityBar.Visible = true;
            doneBtn2.Visible = true;
            //this.Opacity -= .5;
        }

        private void opacityBar_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)opacityBar.Value / 10;          
        }

        private void doneBtn2_Click(object sender, EventArgs e)
        {            
            opacityBar.Visible = false;
            doneBtn2.Visible = false;
            save();
        }
    }
}
