using System;
using System.Collections.Generic;
using System.Text;

namespace KonyvtarApp
{
    internal class Konyv
    {
        public string Cim;

        public int Oldalszam { get;
            set
            {

                if (Oldalszam < 0)
                {
                    Console.WriteLine("A megadott oldalszam nem lehet negatív.");
                } else
                {
                    return;
                }

            }


             }
        public void konyv(string cim,int oldalszam) 
        {
            cim = Cim;
            oldalszam = Oldalszam;
        }

       
    }
}
