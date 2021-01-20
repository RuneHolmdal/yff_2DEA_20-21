/*
 * V3 er lik V2
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Må ha System.IO for å gjøre filaksess
using System.IO;

namespace Adressebok2021V3
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

        int i = 0;
        private void lbInnhold_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = lbInnhold.SelectedIndex;
            // Eksempel 
            // Dersom innhold i oppføringerSL[i] er "Rune,3232323"
            // Blir stringen delt, og innhold i opf blir:
            // opf[0] <- Rune
            // opf[1] <- 3232323
            string[] opf = oppføringerSL[i].Split(',');
            tbNavn.Text = opf[0];
            tbTlf.Text = opf[1];
            tbEpost.Text = opf[2];
            btRediger.Enabled = true;
            btLagre.Enabled = false;
        }

        private void btLagre_Click(object sender, EventArgs e)
        {
            oppføringerSL.Add(tbNavn.Text + "," + tbTlf.Text + "," + tbEpost.Text);
            lbInnhold.Items.Add(tbNavn.Text + "," + tbTlf.Text + "," + tbEpost.Text);
            lbAntall.Text = oppføringerSL.Count.ToString();
            tbNavn.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btRediger.Enabled = false;
            //Les data fra fil
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
                lbAntall.Text = Convert.ToString(oppføringerSL.Count);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Lagre endring?", "OBS!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // skriv data til fil
                using (StreamWriter sw = new StreamWriter(dataFilNavn))
                {
                    foreach (string o in oppføringerSL)
                    {
                        sw.WriteLine(o);
                    }
                }
            }
        }

        private void btRediger_Click(object sender, EventArgs e)
        {
            oppføringerSL[i] = tbNavn.Text + "," + tbTlf.Text + "," + tbEpost.Text;

            // Oppdatere lbInnhold med gjeldende verdier
            lbInnhold.Items.Clear();
            foreach (string s in oppføringerSL)
            {
                lbInnhold.Items.Add(s);
            }
            btLagre.Enabled = true;
            btRediger.Enabled = false;
        }

        private void btSlett_Click(object sender, EventArgs e)
        {
            if (i >= 0)
            {
                oppføringerSL.RemoveAt(i);
            }
            lbAntall.Text = Convert.ToString(oppføringerSL.Count);
            // Oppdatere lbInnhold med gjeldende verdier
            lbInnhold.Items.Clear();
            foreach (string s in oppføringerSL)
            {
                lbInnhold.Items.Add(s);
            }
        }
    }
}
