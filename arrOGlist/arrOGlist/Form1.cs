using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrOGlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Deklarasjon av int tabell med de 7 verdiene: 2, 8, 9, 5, 7, 3 og 6  
        int[] tabell1 = { 2, 8, 9, 5, 7, 3, 6 };
        //indeks:         0  1  2  3  4  5  6 (posisjon/celle referanse)
        //Length: 7 (antall verdier/celler/posisjoner)
        //NB! Største indeks verdi er alltid Length - 1.

        //Deklarasjon av float tabell med 10 verdier, som alle er 0
        float[] tabell2 = new float[10];

        //Deklarasjon av en Button tabell med plass til 6 Button's
        Button[] b = new Button[6];

        //Deklasrasjon av List med String
        List<string> enStringListe = new List<string> {"desember", "jul", "advent", "kalender" };

        private void Form1_Load(object sender, EventArgs e)
        {
            EnkelTabellEks1();
            TabellGjennomsnitt();
            EnkelTabellEks2();
            richTextBox1.Text +="Gjennomsnittsverdi: " + TabellGjennomsnittReturnert(tabell2);
        }
        private void EnkelTabellEks1()
        {
            //richTextBox1.Text = "" + tabell1[5];
            //tabell1[0] = 10;
            //richTextBox1.Text = "" + tabell1[5];
            //tabell1[7] = 17;

            for (int i = 0; i < tabell1.Length; i++)
            {
                richTextBox1.Text += tabell1[i] + ", ";
            }
            richTextBox1.Text += "\n"; // NB! Spesialtegnet \n = linjeskift
        }

        private void TabellGjennomsnitt()
        {
            int sum = 0;
            float snitt = 0.0F;
            for (int i = 0; i < tabell1.Length; i++)
            {
                sum += tabell1[i];
            }
            snitt = (float)sum / tabell1.Length;
            richTextBox1.Text += "Sum: " + sum + ", Snitt: " + snitt + "\n";
        }

        private void EnkelTabellEks2()
        {
            //richTextBox1.Text += "\n" + tabell2[5];

            // Fyller opp tabellen med tilfeldige desimaltall
            Random r = new Random();
            for (int i = 0; i < tabell2.Length; i++)
            {
                float nr = r.Next(100) * 2.53F;
                if (i == 0)
                    tabell2[i] = nr;
                else
                    tabell2[i] = i * nr;
            }

            // Skriver ut tallene i tabell2
            for (int i = 0; i < tabell2.Length; i++)
            {
                richTextBox1.Text += tabell2[i] + "; ";
            }
            richTextBox1.Text += "\n";
        }

        private float TabellGjennomsnittReturnert(float[] t)
        {
            float sum = 0;
            float snitt = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }
            snitt = sum / t.Length;
            return snitt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b[0] = button1;
            b[1] = button2;
            b[2] = button3;
            b[3] = button4;
            b[4] = button5;
            b[5] = button6;
            for (int i = 0; i < b.Length-1; i++)
            {
                b[i + 1].Location = new Point(b[i].Location.X + 76, b[i].Location.Y);
            }
        }

        bool vEnable = true;
        private void button6_Click(object sender, EventArgs e)
        {
            vEnable = !vEnable;
            foreach (Button bb in b)
            {
                if (bb.Name != "button6")
                    bb.Visible = vEnable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] t = { "hoho", "sjegg", "julepynt" };
            enStringListe.Add("Julenisse");
            foreach (string s in t)
            {
                enStringListe.Add(s);
            }

            richTextBox1.Text += "\n\n**************************\n";
            foreach (string a in enStringListe)
            {
                richTextBox1.Text += a + "\n";
            }
        }
    }
}
