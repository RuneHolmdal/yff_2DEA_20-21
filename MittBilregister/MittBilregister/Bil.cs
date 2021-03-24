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

        
        public Bil() { }

        public Bil(string merke, int årsModell)
        {
            Merke = merke;
            Årsmodell = årsModell;
        }

    }
}