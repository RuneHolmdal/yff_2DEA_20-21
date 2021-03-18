using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAvEgetBibliotek
{
    class MittBibliotek_B
    {

        /*
        /// <summary>
        /// Kode basert på den innebygde string metoden Contains. 
        /// </summary>
        /// <param name="søkeOrd"></param>
        /// <param name="tekst"></param>
        /// <returns></returns>
        public bool FinnOrdITekst(string søkeOrd, string tekst)
        {
            if (tekst.Contains(søkeOrd))
                return true;
            else
                return false;
        }
        */

        /// <summary>
        /// Hvis "søkeOrd" finnes i "tekst" returneres true, ellers false.
        /// Koden er basert på at string er array orientert.
        /// Ytterste for-løkke søker i "tekst" etter tegn som samsvarer
        /// med første tegn i "søkeOrd". Når det inntreffer, søker innerste
        /// for-løkke om etterfølgende tegn samsvarer. 
        /// </summary>
        /// <param name="søkeOrd"></param>
        /// <param name="tekst"></param>
        /// <returns></returns>
        public bool FinnOrdITekst(string søkeOrd, string tekst)
        {
            bool so = false;
            for (int i_t = 0; i_t < tekst.Length; i_t++)
            {
                if (søkeOrd.Length + i_t <= tekst.Length)
                {
                    if (søkeOrd[0] == tekst[i_t])
                    {
                        if (søkeOrd.Length == 1)
                        {
                            so = true;
                            break;
                        }
                        else
                        {
                            for (int i_o = 1; i_o < søkeOrd.Length; i_o++)
                            {
                                if (søkeOrd[i_o] != tekst[i_o + i_t])
                                {
                                    so = false;
                                    break;
                                }
                                else
                                    so = true;
                            }
                        }
                    }
                }
            }
            return so;
        }
    }
}
