using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkjermKalk2DEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal tall1 = 0;
        string regnoperasjon = "";

        #region talltaster og komma
        private void BtnKomma_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
                display.Text = display.Text + ",";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            // hvis displayet ikke viser 0 --> Legg til en 0
            if (display.Text != "0")
                display.Text = display.Text + btn0.Text;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            /* hvis display viser 0 --> overskriv med tallet 1
             * hvis ikke --> legg tallet 1 til bakerst. */
            if (display.Text == "0")
                display.Text = btn1.Text;
            else
                display.Text = display.Text + btn1.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn2.Text;
            else
                display.Text = display.Text + btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn3.Text;
            else
                display.Text = display.Text + btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn4.Text;
            else
                display.Text = display.Text + btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn5.Text;
            else
                display.Text = display.Text + btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn6.Text;
            else
                display.Text = display.Text + btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn7.Text;
            else
                display.Text = display.Text + btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn8.Text;
            else
                display.Text = display.Text + btn8.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = btn9.Text;
            else
                display.Text = display.Text + btn9.Text;
        }
        #endregion

        #region regnetaster

        private void BtnErlik_Click(object sender, EventArgs e)
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

        private void BtnPluss_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(display.Text);
            display.Text = "0";
            regnoperasjon = btnPluss.Text;
        }
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(display.Text);
            display.Text = "0";
            regnoperasjon = btnMinus.Text;
        }

        private void BtnGange_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(display.Text);
            display.Text = "0";
            regnoperasjon = btnGange.Text;
        }

        private void BtnDele_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDecimal(display.Text);
            display.Text = "0";
            regnoperasjon = btnDele.Text;
        }
        #endregion

        #region slettetaster
        private void BtnSlett_Click(object sender, EventArgs e)
        {
            tall1 = 0;
            regnoperasjon = "";
            display.Text = "0";
        }

        private void BtnSlettTilbake_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 1)
                display.Text = display.Text.Remove(display.Text.Length - 1);
            else
                display.Text = "0";
        }
        #endregion 
    }
}
