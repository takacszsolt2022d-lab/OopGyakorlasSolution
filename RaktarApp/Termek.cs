using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace RaktarApp
{
    internal class Termek
    {
        public string Nev { get; set; }

        public int Egysegar { get; private set; }

        public static int TermekSzamlalo { get; set; }


        public void konstruktor(string nev,int egysegar)
        {
            nev = Nev;
            egysegar = Egysegar;
            TermekSzamlalo++;
        }
    }
}
