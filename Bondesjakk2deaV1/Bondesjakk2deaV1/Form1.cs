using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondesjakk2deaV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool xActive = true;

        private void Spill_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Text != "X" && b.Text != "O")
            {
                if (xActive)
                    b.Text = "X";
                else
                    b.Text = "O";
                xActive = !xActive;
                SjekkVinner();
            }
        }

        private void SjekkVinner()
        {
            bool xVinner = (b11.Text == "X" && b12.Text == "X" && b13.Text == "X") ||
                            (b21.Text == "X" && b22.Text == "X" && b23.Text == "X") ||
                            (b31.Text == "X" && b32.Text == "X" && b33.Text == "X");
            
            Console.WriteLine(xVinner);
        }

    }
}
