using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpillDemo2DEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "" + this.Width;
            label4.Text = "" + this.Left;

            timer1.Start();
            //pictureBox1.Location = new Point(100, 0);
        }
        
        int retning = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int xPos = pictureBox1.Location.X;
            int yPos = pictureBox1.Location.Y;

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            //if(pictureBox1.Location.X + pictureBox1.Width > this.Right)
            {
                //MessageBox.Show("Kollisjon");
                retning *= -1;
            }
            xPos += 10 * retning;
            pictureBox1.Location = new Point(xPos, yPos);

        }
    }
}
