using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MittBilregister
{
    public partial class Form1 : Form
    {
        List<Bil> bilRegister = new List<Bil>();
        public Form1()
        {
            InitializeComponent();
            DemoBiler();
        }

        private void btnLagre_Click(object sender, EventArgs e)
        {
            try
            {
                bilRegister.Add(new Bil(tbBilMerke.Text, Convert.ToInt32(tbÅrsmodell.Text), Convert.ToDecimal(tbForbruk.Text)));
                OppdaterVisuellListe();
            }
            catch
            {
                MessageBox.Show("Noe gikk galt! Bilen ble ikke lagret.");
            }
            RyddTekstBokser();
            tbBilMerke.Focus();
        }

        private void OppdaterVisuellListe()
        {
            listBoxBiler.Items.Clear();
            foreach (Bil b in bilRegister)
            {
                listBoxBiler.Items.Add(b.Merke + ", " + b.Årsmodell + ", " + b.Forbruk + ", " + b.Veteran());
            }
        }

        private void RyddTekstBokser()
        {
            tbBilMerke.Text = "";
            tbÅrsmodell.Text = "";
        }
        
        private void DemoBiler()
        {
            bilRegister.Add(new Bil("Ford", 2000));
            bilRegister.Add(new Bil("Kia", 2001));
            bilRegister.Add(new Bil("Nissan", 1999));
            bilRegister.Add(new Bil("Opel", 2012));
            bilRegister.Add(new Bil("Mazda", 2021));
            OppdaterVisuellListe();
        }
    }
}
