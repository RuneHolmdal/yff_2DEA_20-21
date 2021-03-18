using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAvEgetBibliotek
{
    class MittBibliotek_A
    {
        public int AddisjonAvToTall(int a, int  b)
        {
            return a + b;
        }

        public int SubtraksjonAvToTall(int a, int b)
        {
            return a - b;
        }

        public int DivisjonAvToTall(int a, int b)
        {
            int r = 0;
            try { r = a / b; }
            catch
            {
                MessageBox.Show("FEIL!!!!!!\nNB! Du kan ikke dele på 0");
            }
            return r;
        }

        /*
         * 1. Lag en ny klasse
         * 2. Lag metoden "public bool FinnOrdITekst (string søkeOrd, string tekst)"
         *    Tips! if (tekst.Contains(søkeOrd))
         *    Utfordring! Ikke bruk Contains.
         * 3. Test metoden
         * 4. Forklar hva du har gjordt for lærer og medelever.
        */
    }
}
