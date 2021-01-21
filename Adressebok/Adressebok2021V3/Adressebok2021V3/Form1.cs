/*
 * V3 er lik V2, men skal skrives om til bruk av klasse.
 * Se Person.cs
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

        List<Person> personer = new List<Person>();
        

        string dataFilNavn = "data.txt";

        private void tbSøk_TextChanged(object sender, EventArgs e)
        {
            lbInnhold.Items.Clear();
            for (int i = 0; i < personer.Count; i++)
            {
                if (personer[i].Navn.Contains(tbSøk.Text))
                {
                    lbInnhold.Items.Add(personer[i].Navn);
                }
            }
        }

        int i = 0;
        private void lbInnhold_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = lbInnhold.SelectedIndex;
            tbNavn.Text = personer[i].Navn;
            tbTlf.Text = personer[i].Telefon;
            tbEpost.Text = personer[i].Epost;

            btRediger.Enabled = true;
            btLagre.Enabled = false;
        }

        private void btLagre_Click(object sender, EventArgs e)
        {
            //lagrer data i personer listen
            Person p = new Person(tbNavn.Text, tbTlf.Text, tbEpost.Text);
            personer.Add(p);

            //viser innhold og antall
            lbInnhold.Items.Add(tbNavn.Text);
            lbAntall.Text = personer.Count.ToString();

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
                        string[] opf = linje.Split(',');
                        //tbNavn.Text = opf[0];
                        //tbTlf.Text = opf[1];
                        //tbEpost.Text = opf[2];

                        Person p = new Person(opf[0], opf[1], opf[2]);
                        personer.Add(p);
                        lbInnhold.Items.Add(p.Navn);
                    }
                }
                lbAntall.Text = Convert.ToString(personer.Count);
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
                    foreach (Person p in personer)
                    {
                        sw.WriteLine(p.Navn + "," + p.Telefon + "," + p.Epost);
                    }
                }
            }
        }

        private void btRediger_Click(object sender, EventArgs e)
        {
            personer[i].Navn = tbNavn.Text;
            personer[i].Telefon = tbTlf.Text;
            personer[i].Epost = tbEpost.Text;

            // Oppdatere lbInnhold med gjeldende verdier
            lbInnhold.Items.Clear();
            foreach (Person p in personer)
            {
                lbInnhold.Items.Add(p.Navn);
            }
            btLagre.Enabled = true;
            btRediger.Enabled = false;
        }

        private void btSlett_Click(object sender, EventArgs e)
        {
            if (i >= 0)
            {
                personer.RemoveAt(i);
            }
            lbAntall.Text = Convert.ToString(personer.Count);
            // Oppdatere lbInnhold med gjeldende verdier
            lbInnhold.Items.Clear();
            foreach (Person p in personer)
            {
                lbInnhold.Items.Add(p.Navn);
            }
        }
    }
}
