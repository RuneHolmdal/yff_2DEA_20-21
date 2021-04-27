using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HjemmeOppgave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xPos = pictureBox3.Location.X;
            yPos = pictureBox3.Location.Y;
        }
        // Valuttaer                USD     EUR       GBP     BTC
        double[] valuttaKurser = { 8.3637, 10.0423, 11.6432, 466783 };
        double[] valuttaKjøp = { 4823, 26432, 77954 };
        double[,] verdier = new double[3, 4];

        // beregn hvor mye du får i hver valutta for de tre ulike vediene
        private void btnBeregn_Click(object sender, EventArgs e)
        {
            verdier = res(valuttaKurser, valuttaKjøp);
            /*
            for (int i = 0; i < verdier.Length; i++)
            {
                for (int j = 0; j < valuttaKurser.Length; j++)
                {
                    resultat[i, j] = verdier[i] * valuttaKurser[j];
                }
            }
            */
            Utskrift();
        }

        private void Utskrift()
        {
            richTextBox1.Text = "NOK\t\tUSD\t\tEUR\t\tGBP\t\tBTC\n";
            for (int x = 0; x < 3; x++)
            {
                richTextBox1.Text += valuttaKjøp[x];
                for (int y = 0; y < 4; y++)
                {
                    richTextBox1.Text += "\t" + verdier[x, y];
                }
                richTextBox1.Text += "\n";
            }
        }

        double[,] res(double[] kurs, double[] sum)
        {
            double[,] r = new double[3, 4];
            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = 0; j < kurs.Length; j++)
                {
                    r[i, j] = Math.Round(sum[i] / kurs[j], 2);
                }
            }
            return r;
        }

        private void btnRotKtrl_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                btnRotKtrl.BackColor = Color.Red;
                btnRotKtrl.Text = "STOP";
                timer1.Start(); // endrer timer1.Enabled til true
            }
            else
            {
                btnRotKtrl.BackColor = Color.Green;
                btnRotKtrl.Text = "START";
                timer1.Stop(); // endrer timer1.Enabled til false
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RoterPB1();
        }

        private void RoterPB1()
        {
            Image b = pictureBox1.Image;
            b.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = b;
        }
        private void RoterPB2()
        {
            Image b = pictureBox2.Image;
            b.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = b;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer2.Start();

            if (trackBar1.Value == 0)
            {
                timer2.Stop();
            }
            if (trackBar1.Maximum - trackBar1.Value > 0)
            { 
                timer2.Interval = (trackBar1.Maximum - trackBar1.Value) * 50;
            }
            else
            {
                timer2.Interval = 40;
            }
            label1.Text = Convert.ToString(trackBar1.Value) + ", " + trackBar1.Value * 17.4 + " km/h";
        }

        private void btnFlytt_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        // xPos og yPos benyttes bare her. Setter PB2 i utgangsposisjon
        // Utgangsposisjons verdiene tilordnes i public Form1()
        int xPos, yPos;

        private void timer2_Tick(object sender, EventArgs e)
        {
            RoterPB2();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Flytt();
        }

        private void Flytt()
        {
            if (!pictureBox3.Bounds.Contains(btnFlytt.Bounds))
                pictureBox3.Location = new Point(pictureBox3.Location.X + 5, pictureBox3.Location.Y);
            else
            {
                pictureBox3.Location = new Point(xPos, yPos);
                timer3.Stop();
            }
        }
    }
}
