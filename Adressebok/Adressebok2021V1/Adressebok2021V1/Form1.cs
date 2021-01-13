/*
 * I V1 av adresseboken startet vi med å bygge opp funksjonalitet
 * basert på det vi kunne basert på array.
 * For å få til en dynamisk adressebok der antall registreringer
 * ikke er en begrensning for brukeren, skrives koden og
 * array byttes ut med List.
 * Oppføringer leses fra og skrives til en lokal fil.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Må ha System.IO for å gjøre filaksess
using System.IO; 

namespace Adressebok2021V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Adresseboken er lagret på en fil
        string dataFilNavn = "data.txt";

        // Vi startet med å lage en adressebok som var basert på det vi kunne,
        // og brukte array.

        #region Adressebok basert på array. NB! Kommentert ut.
        // NB! Når det brukes array er antall oppføringer begrenset til ett
        // forhåndsbestemt antall (Se maksAntallOppføringer).

        //const int maksAntallOppføringer = 5;
        //string[] oppføringerSA = new string[maksAntallOppføringer];
        //int antOppføringer = 0;

        //private void btLagre_Click(object sender, EventArgs e)
        //{
        //    if(antOppføringer < maksAntallOppføringer)
        //    {
        //        oppføringerSA[antOppføringer] = tbNavn.Text + "," + tbTlf.Text;
        //        lbInnhold.Items.Add(tbNavn.Text + "," + tbTlf.Text);
        //        antOppføringer++;
        //        lbAntall.Text = antOppføringer.ToString();
        //        // Setter fokus på tbNavn
        //        tbNavn.Focus();
        //    }
        //}


        //private void lbInnhold_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int i = lbInnhold.SelectedIndex;
        //    // Eksempel 
        //    // Dersom innhold i oppføringerSL[i] er "Rune,3232323"
        //    // Blir stringen delt, og innhold i opf blir:
        //    // opf[0] <- Rune
        //    // opf[1] <- 3232323
        //    string[] opf = oppføringerSA[i].Split(',');
        //    tbNavn.Text = opf[0];
        //    tbTlf.Text = opf[1];
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //Les fra fil
        //    if (File.Exists(dataFilNavn))
        //    {
        //        using (StreamReader sr = new StreamReader(dataFilNavn))
        //        {
        //            string linje;
        //            while ((linje = sr.ReadLine()) != null)
        //            {
        //                if ( antOppføringer < maksAntallOppføringer)
        //                {
        //                    oppføringerSA[antOppføringer] = linje;
        //                    lbInnhold.Items.Add(linje);
        //                    antOppføringer++;
        //                    lbAntall.Text = antOppføringer.ToString();
        //                }
        //            }
        //        }
        //    }
        //}

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show("Lagre endring?", "OBS!", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        using (StreamWriter sw = new StreamWriter(dataFilNavn))
        //        {
        //            foreach (string o in oppføringerSA)
        //            {
        //                sw.WriteLine(o);
        //            }
        //        }
        //    }
        //}

        #endregion

        // Så ble koden skrevet om, med bruk av List
        #region Adressebok basert på List. Aktiv kode.
        // Viktig! Når koden skrives om med List istedet for array
        // er ikke antall noen begrensning lenger.
        // array er statiske, mens List er dynamiske!

        List<string> oppføringerSL = new List<string>();

        private void btLagre_Click(object sender, EventArgs e)
        {
            oppføringerSL.Add(tbNavn.Text + "," + tbTlf.Text);
            lbInnhold.Items.Add(tbNavn.Text + "," + tbTlf.Text);
            lbAntall.Text = oppføringerSL.Count.ToString();
            tbNavn.Focus();
        }

        // Hvis det eksisterer en fil med oppføringer så lese de inn i adresseboken,
        // når applikasjonen starter.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Les fra fil
            if (File.Exists(dataFilNavn))
            {
                // using holder styr på filaksessen.
                // Åpner filen når den skal brukes og lukker den når arbeid med filen er ferdig.
                using (StreamReader sr = new StreamReader(dataFilNavn))
                {
                    string linje;
                    while ((linje = sr.ReadLine()) != null)
                    {
                        oppføringerSL.Add(linje);
                        lbInnhold.Items.Add(linje);
                        lbAntall.Text = oppføringerSL.Count.ToString();
                    }
                }
            }
        }

        // Når applikasjonen avsluttes må brukeren ta stilling til om oppføringene i 
        // adresseboken skal lagres på fil.
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
        #endregion
    }
}
