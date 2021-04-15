using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAvMinEgenKonvertKlasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MinKonvKlasse mm = new MinKonvKlasse();

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            double c = Convert.ToDouble(textBox1.Text);
            //°F = (°C × 9/5) + 32
            double f = (c * 9 / 5) + 32;
            label2.Text = Convert.ToString(f);
            */

            /* To like måter (funksjonsmessig), men siste har alt på en linje
            double c = Convert.ToDouble(textBox1.Text);
            label2.Text = Convert.ToString(mm.ConvCelToFar(c));
            */
            label2.Text = Convert.ToString(mm.ConvCelToFar(Convert.ToDouble(textBox1.Text)));
            label2.Text = Convert.ToString(ConvCelToFar(Convert.ToDouble(textBox1.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(mm.ConvFarToCel(Convert.ToDouble(textBox2.Text)));
        }

        public double ConvCelToFar(double c)
        {
            //°F = (°C × 9/5) + 32
            return (c * 9 / 5) + 32;
        }
    }
}
