/*
 * V2 er lik V1, men her la vi til søke funksjon og
 * mulighet til å velge hvilken oppføring som skal
 * bli presentert i tekstfeltene for navn og nr.
 * Dette kan være nyttig funksjonalitet når 
 * eksisterende registreringer skal redigeres.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Må ha System.IO for å gjøre filaksess
using System.IO;

namespace Adressebok2021V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> oppføringerSL = new List<string>();
        string dataFilNavn = "data.txt";

        private void tbSøk_TextChanged(object sender, EventArgs e)
        {
            lbInnhold.Items.Clear();
            for (int i = 0; i < oppføringerSL.Count; i++)
            {
                if (oppføringerSL[i].Contains(tbSøk.Text))
                {
                    lbInnhold.Items.Add(oppføringerSL[i]);
                }
            }
        }

        private void lbInnhold_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbInnhold.SelectedIndex;
            // Eksempel 
            // Dersom innhold i oppføringerSL[i] er "Rune,3232323"
            // Blir stringen delt, og innhold i opf blir:
            // opf[0] <- Rune
            // opf[1] <- 3232323
            string[] opf = oppføringerSL[i].Split(',');
            tbNavn.Text = opf[0];
            tbTlf.Text = opf[1];
        }

        private void btLagre_Click(object sender, EventArgs e)
        {
            oppføringerSL.Add(tbNavn.Text + "," + tbTlf.Text);
            lbInnhold.Items.Add(tbNavn.Text + "," + tbTlf.Text);
            lbAntall.Text = oppføringerSL.Count.ToString();
            tbNavn.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Les fra fil
            if (File.Exists(dataFilNavn))
            {
                using (StreamReader sr = new StreamReader(dataFilNavn))
                {
                    string linje;
                    while ((linje = sr.ReadLine()) != null)
                    {
                        oppføringerSL.Add(linje);
                        lbInnhold.Items.Add(linje);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Lagre endring?", "OBS!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (StreamWriter sw = new StreamWriter(dataFilNavn))
                {
                    foreach (string o in oppføringerSL)
                    {
                        sw.WriteLine(o);
                    }
                }
            }
        }
    }
}
