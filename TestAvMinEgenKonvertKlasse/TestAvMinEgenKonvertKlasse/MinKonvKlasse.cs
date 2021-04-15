using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAvMinEgenKonvertKlasse
{
    class MinKonvKlasse
    {
        //Default konstruktør (innebygd i C# - vi trenger ikke skrive den)
        public MinKonvKlasse() 
        { }

        public double ConvCelToFar(double c)
        {
            //°F = (°C × 9/5) + 32
            return (c * 9 / 5) + 32;
        }

        public double ConvFarToCel(double f)
        {
            //°C = (°F − 32) × 5/9
            return (f - 32) * 5 / 9;
        }

    }
}
