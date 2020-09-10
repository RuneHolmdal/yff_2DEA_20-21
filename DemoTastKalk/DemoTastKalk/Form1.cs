using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTastKalk
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TallTast_Click(object sender, EventArgs e)
        {
            Button tallTast = sender as Button;

            if (display.Text == "0")
                display.Text = tallTast.Text;
            else
                display.Text = display.Text + tallTast.Text;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    btn0.PerformClick();
                    break;
                case Keys.D1:
                    btn1.PerformClick();
                    break;
                case Keys.D2:
                    btn2.PerformClick();
                    break;
                case Keys.D3:
                    btn3.PerformClick();
                    break;
                case Keys.D4:
                    btn4.PerformClick();
                    break;
                case Keys.D5:
                    btn5.PerformClick();
                    break;
                case Keys.D6:
                    btn6.PerformClick();
                    break;
                case Keys.D7:
                    btn7.PerformClick();
                    break;
                case Keys.D8:
                    btn8.PerformClick();
                    break;
                case Keys.D9:
                    btn9.PerformClick();
                    break;
            }
        }

        // Globale variabler
        decimal tall1 = 0;
        string regnoperasjon = "";

        private void RegneTast_Click(object sender, EventArgs e)
        {
            //Lokal variabel - lokalt objekt/instans
            Button regneTast = sender as Button;
            tall1 = Convert.ToDecimal(display.Text);
            display.Text = "0";
            regnoperasjon = regneTast.Text;
        }

        private void btnErlik_Click(object sender, EventArgs e)
        {
            decimal tall2 = Convert.ToDecimal(display.Text);
            decimal regneResultat = 0;
            if (regnoperasjon == "+")
                regneResultat = tall1 + tall2;
            else if (regnoperasjon == "-")
                regneResultat = tall1 - tall2;
            else if (regnoperasjon == "*")
                regneResultat = tall1 * tall2;
            else if (regnoperasjon == "/")
                regneResultat = tall1 / tall2;

            display.Text = Convert.ToString(regneResultat);
        }
    }
}
