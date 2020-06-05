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
        private int probalkozasokSzama;
        private long jatszottMasodperc;
        private int levettParokSzama;

        public Helyezes(String sor)
        {
            String[] adatok = sor.Split(';');
            this.nev = adatok[0];
            this.ProbalkozasokSzama = int.Parse(adatok[1]);
            this.jatszottMasodperc = long.Parse(adatok[2]);
            this.levettParokSzama = int.Parse(adatok[3]);
        }

        public Helyezes(string nev, int szint, long jatszottMasodperc, int levettParokSzama)
        {
            this.nev = nev;
            this.ProbalkozasokSzama = szint;
            this.jatszottMasodperc = jatszottMasodperc;
            this.levettParokSzama = levettParokSzama;
        }

        public string Nev { get => nev; set => nev = value; }
        public long JatszottMasodperc { get => jatszottMasodperc; set => jatszottMasodperc = value; }
        public int ProbalkozasokSzama { get => probalkozasokSzama; set => probalkozasokSzama = value; }
        public int LevettParokSzama { get => levettParokSzama; set => levettParokSzama = value; }
    }
}
