using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prøve_2021_04_22
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent();
		}

		// Valuttaer USD EUR GBP BTC
		string[] valuttaType = { "USD", "EUR", "GBP", "BTC" };
		double[] valuttaKurser = { 8.3637, 10.0423, 11.6432, 466783 };
		double[] valuttaKjøp = { 4823, 26432, 77954 };
		double[,] verdier = new double[3, 4];

		private void Form1_Load (object sender, EventArgs e)
		{
			richTextBox1.Text = "NOK\t\tUSD\t\tEUR\t\tGBP\t\tBTC\n\n";
		}

		#region Oppg1
		private void calculateTrade()
		{
			verdier = new double[3, 4];

			for(int round = 0; round < verdier.GetLength(0); round++)
			{
				verdier[round, 0] = valuttaKjøp[round];

				for(int i = 0; i < valuttaType.Length; i++)
				{
					double value = valuttaKjøp[round] / valuttaKurser[i];

					if(valuttaType[i] == "BTC")
					{
						verdier[round, i] = Math.Round(value, 8);
					}
					else
					{
						verdier[round, i] = Math.Round(value, 2);
					}
				}
			}

			

			/*
			for(int i = 0; i < valuttaKurser.Length; i++)
			{
				double value = nok / valuttaKurser[i];
				if(i + 1 != valuttaKurser.Length)
				{
					retur += Math.Round(value, 2);
					retur += "\t\t";
				}
				else
				{
					retur += Math.Round(value, 8);
					retur += "\n";
				}
			}
			*/
		}

		private void button1_Click (object sender, EventArgs e)
		{
			calculateTrade();

			for(int x = 0; x < verdier.GetLength(0); x++)
			{
				string line = valuttaKjøp[x] + "\t\t";
				for(int y = 0; y < verdier.GetLength(1); y++)
				{
					line += verdier[x, y];
					if(y + 1 != verdier.GetLength(1))
						line += "\t\t";
				}
				richTextBox1.Text += line + "\n";
			}
		}
		#endregion

		#region Oppg2

		bool currentState = false;

		private void timer1_Tick (object sender, EventArgs e)
		{
			Image img = pictureBox1.Image;
			img.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox1.Image = img;
		}

		private void button2_Click (object sender, EventArgs e)
		{
			currentState = !currentState;

			if(currentState)
			{
				button2.Text = "Stop";
				button2.BackColor = Color.FromArgb(255, 255, 0, 0);
				timer1.Enabled = true;
			}
			else
			{
				button2.Text = "Start";
				button2.BackColor = Color.FromArgb(255, 0, 255, 0);
				timer1.Enabled = false;
			}
		}

		#endregion

		#region Oppg3



		#endregion

		#region Oppg4

		int increment = 4;
		int origin = 8;


		private void button3_Click (object sender, EventArgs e)
		{
			Oppg4Timer.Enabled = true;
			button3.Enabled = false;
			button3.Text = "Running...";
			button3.BackColor = Color.FromArgb(255, 255, 0, 0);
		}

		private void Oppg4Timer_Tick (object sender, EventArgs e)
		{
			PictureBox p = Oppg4PB;

			p.Left += increment;

			if(p.Bounds.IntersectsWith(button3.Bounds))
			{
				p.Left = origin;
				Oppg4Timer.Enabled = false;
				button3.Enabled = true;
				button3.Text = "Start";
				button3.BackColor = Color.FromArgb(255, 0, 255, 0);
			}
		}

		#endregion
	}
}
