using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MittBilregister
{
    class Bil
    {
        //attributter
        public string Merke { get; set; }
        public int Årsmodell { get; set; }
        public decimal Forbruk { get; set; }

        private bool veteran;
        const int antÅrVeteran = 30;

        #region konstruktører
        public Bil() { }
        
        public Bil(string merke, int årsModell)
        {
            Merke = merke;
            Årsmodell = årsModell;
            veteran = SjekkVeteranStatus();
        }
        
        public Bil(string merke, int årsModell, decimal literPrMil)
        {
            Merke = merke;
            Årsmodell = årsModell;
            Forbruk = literPrMil;
            veteran = SjekkVeteranStatus();

        }
        #endregion

        #region private funksjoner
        private bool SjekkVeteranStatus()
        {
            int år = DateTime.Now.Year;
            return (år - Årsmodell > antÅrVeteran);
        }
        #endregion

        #region public metoder
        public string Veteran()
        {
            if (veteran)
                return "Veteran";
            else
                return "Ikke veteran";
        }
        #endregion
    }
}