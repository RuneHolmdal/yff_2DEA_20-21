using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressebok2021V3
{
    class Person
    {
        // Egenskaper
        public string Navn { get; set; }
        public string Epost { get; set; }
        public string Telefon { get; set; }

        // Konstruktører

        public Person() { } //oppretter ett tomt objekt (standard konstruktør)

        public Person(string n, string t, string e) //oppretter ett objekt med innhold
        {
            Navn = n;
            Telefon = t;
            Epost = e;
        }

    }
}
