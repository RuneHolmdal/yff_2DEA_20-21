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
        const int maksAntallTrekk = 9;
        int antallTrekk = 0;

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
                antallTrekk++;  //antallTrekk = antallTrekk + 1;
                SjekkVinner();
            }
        }

        private bool Vinner(string spiller)
        {
            bool vinner = (b11.Text == spiller && b12.Text == spiller && b13.Text == spiller) ||
                        (b21.Text == spiller && b22.Text == spiller && b23.Text == spiller) ||
                        (b31.Text == spiller && b32.Text == spiller && b33.Text == spiller) ||
                        (b11.Text == spiller && b21.Text == spiller && b31.Text == spiller) ||
                        (b12.Text == spiller && b22.Text == spiller && b32.Text == spiller) ||
                        (b13.Text == spiller && b23.Text == spiller && b33.Text == spiller) ||
                        (b11.Text == spiller && b22.Text == spiller && b33.Text == spiller) ||
                        (b13.Text == spiller && b22.Text == spiller && b31.Text == spiller);
            return vinner;
        }

        private void SjekkVinner()
        {

            if (Vinner("X"))
            {
                MessageBox.Show("X vant!");
                KontrollerSpillflate(false);
            }
            else if (Vinner("O"))
            {
                MessageBox.Show("O vant!");
                KontrollerSpillflate(false);
            }
            else
            {
                if (antallTrekk == maksAntallTrekk)
                    MessageBox.Show("Uavgjordt!");
            }
        }

        private void SjekkVinner_old()
        {
            bool xVinner = (b11.Text == "X" && b12.Text == "X" && b13.Text == "X") ||
                            (b21.Text == "X" && b22.Text == "X" && b23.Text == "X") ||
                            (b31.Text == "X" && b32.Text == "X" && b33.Text == "X") ||
                            (b11.Text == "X" && b21.Text == "X" && b31.Text == "X") ||
                            (b12.Text == "X" && b22.Text == "X" && b32.Text == "X") ||
                            (b13.Text == "X" && b23.Text == "X" && b33.Text == "X") ||
                            (b11.Text == "X" && b22.Text == "X" && b33.Text == "X") ||
                            (b13.Text == "X" && b22.Text == "X" && b31.Text == "X");
            bool oVinner = (b11.Text == "O" && b12.Text == "O" && b13.Text == "O") ||
                            (b21.Text == "O" && b22.Text == "O" && b23.Text == "O") ||
                            (b31.Text == "O" && b32.Text == "O" && b33.Text == "O") ||
                            (b11.Text == "O" && b21.Text == "O" && b31.Text == "O") ||
                            (b12.Text == "O" && b22.Text == "O" && b32.Text == "O") ||
                            (b13.Text == "O" && b23.Text == "O" && b33.Text == "O") ||
                            (b11.Text == "O" && b22.Text == "O" && b33.Text == "O") ||
                            (b13.Text == "O" && b22.Text == "O" && b31.Text == "O");
            if (xVinner)
            {
                MessageBox.Show("X vant!");
                KontrollerSpillflate(false);
            }
            else if (oVinner)
            {
                MessageBox.Show("O vant!");
                KontrollerSpillflate(false);
            }
            else
            {
                if (antallTrekk == maksAntallTrekk)
                    MessageBox.Show("Uavgjordt!");
            }
        }

        private void KontrollerSpillflate(bool k)
        {
            b11.Enabled = k;
            b12.Enabled = k;
            b13.Enabled = k;
            b21.Enabled = k;
            b22.Enabled = k;
            b23.Enabled = k;
            b31.Enabled = k;
            b32.Enabled = k;
            b33.Enabled = k;
        }
        private void bNyttSpill_Click(object sender, EventArgs e)
        {
            xActive = true;
            antallTrekk = 0;
            b11.Text = "";
            b12.Text = "";
            b13.Text = "";
            b21.Text = "";
            b22.Text = "";
            b23.Text = "";
            b31.Text = "";
            b32.Text = "";
            b33.Text = "";
            KontrollerSpillflate(true);
            /* Disse linjene er blitt erstattet av linjen ovenfor
            b11.Enabled = true;
            b12.Enabled = true;
            b13.Enabled = true;
            b21.Enabled = true;
            b22.Enabled = true;
            b23.Enabled = true;
            b31.Enabled = true;
            b32.Enabled = true;
            b33.Enabled = true;
            */
        }
    }
}
