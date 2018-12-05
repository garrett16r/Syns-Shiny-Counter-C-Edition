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
    public partial class IntervalPage : Form
    {
        ShinyCounter sc;

        // Other form has to be passed to the constructor, otherwise variables in ShinyCounter cannot be altered.
        public IntervalPage(ShinyCounter sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int i = (int)intervalBox.Value;
            sc.setInterval(i);
            this.Hide();
        }
    }
}
