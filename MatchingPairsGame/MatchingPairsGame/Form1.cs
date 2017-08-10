using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingPairsGame
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        List<string> icons = new List<string>()
            {
                "!","!","N","N",",",",","k","k",
                "b","b","v","v","w","w","z","z"
            };

        public Form1()
        {
           
            InitializeComponent();
            AssignIconsToSquers();
        }

        private void AssignIconsToSquers()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLable = control as Label;
                if (iconLable != null)
                {
                    int randomNumber = randomNumber = random.Next(icons.Count);
                    iconLable.Text = icons[randomNumber];
                    iconLable.ForeColor = iconLable.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text1_Click(object sender, EventArgs e)
        {

        }
    }
}
