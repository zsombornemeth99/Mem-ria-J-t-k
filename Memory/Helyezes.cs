using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Helyezes
    {
        private String nev;
        private int szint;
        private long jatszottMasodperc;

        public Helyezes(String sor)
        {
            String[] adatok = sor.Split(';');
            this.nev = adatok[0];
            this.szint = int.Parse(adatok[1]);
            this.jatszottMasodperc = long.Parse(adatok[2]);
        }

        public Helyezes(string nev, int szint, long jatszottMasodperc)
        {
            this.nev = nev;
            this.szint = szint;
            this.jatszottMasodperc = jatszottMasodperc;
        }

        public string Nev { get => nev; set => nev = value; }
        public long JatszottMasodperc { get => jatszottMasodperc; set => jatszottMasodperc = value; }
        public int Szint { get => szint; set => szint = value; }
    }
}
