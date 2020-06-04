using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class FrmMemory : Form
    {
        private int maxKep = 99;
        private int sorokSzama;
        private int lapokSzama;
        private int idomeres;
        private int jatekido=0;
        private int probalkozasokSzama;
        private string nev;

        private Random r = new Random();
        private List<int> sorSzamok;

        public FrmMemory(string nev)
        {
            InitializeComponent();
            //megjelenites();
            this.nev = nev;
        }
        public FrmMemory()
        {
            InitializeComponent();
        }

        private void ranglista()
        {
            try
            {
                int szintLocal = 0;
                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                    szintLocal = 1;
                else if(cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                    szintLocal = 2;
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                    szintLocal = 3;
                string nev = this.nev;
                long jatekIdo = this.jatekido;
                IList<Helyezes> rangLista;
                if (File.Exists("ranglista.txt"))
                {

                    List<string> sor = new List<string>();
                    StreamReader sr = new StreamReader("ranglista.txt", Encoding.UTF8);
                    while (!sr.EndOfStream)
                    {
                        sor.Add(sr.ReadLine());
                    }
                    sr.Close();
                    //File.Delete("ranglista.txt");
                    if (sor.Count == 1)
                    {
                        rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[0]),
                            new Helyezes(nev,szintLocal,jatekIdo)
                        };
                        var result = rangLista.OrderByDescending(s => s.Szint).ThenBy(s => s.JatszottMasodperc);
                        StreamWriter sw = new StreamWriter("ranglista.txt", false, Encoding.UTF8);
                        foreach (var std in result)
                        {
                            sw.WriteLine(std.Nev + ";" + std.Szint + ";" + std.JatszottMasodperc);
                        }
                        sw.Close();
                    }
                    else if (sor.Count == 2)
                    {
                        rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[0]),
                            new Helyezes(sor[1]),
                            new Helyezes(nev,szintLocal,jatekIdo)
                        };
                        var result = rangLista.OrderByDescending(s => s.Szint).ThenBy(s => s.JatszottMasodperc);
                        StreamWriter sw = new StreamWriter("ranglista.txt", false, Encoding.UTF8);
                        foreach (var std in result)
                        {
                            sw.WriteLine(std.Nev + ";" + std.Szint + ";" + std.JatszottMasodperc);
                        }
                        sw.Close();
                    }
                    else if (sor.Count == 3)
                    {
                        rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[0]),
                            new Helyezes(sor[1]),
                            new Helyezes(sor[2]),
                            new Helyezes(nev,szintLocal,jatekIdo)
                        };
                        var result = rangLista.OrderByDescending(s => s.Szint).ThenBy(s => s.JatszottMasodperc);
                        StreamWriter sw = new StreamWriter("ranglista.txt", false, Encoding.UTF8);
                        foreach (var std in result)
                        {
                            sw.WriteLine(std.Nev + ";" + std.Szint + ";" + std.JatszottMasodperc);
                        }
                        sw.Close();
                    }
                    else
                    {
                        rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[sor.Count-1]),
                            new Helyezes(nev,szintLocal,jatekIdo)
                        };
                        var result = rangLista.OrderByDescending(s => s.Szint).ThenBy(s => s.JatszottMasodperc);
                        StreamWriter sw = new StreamWriter("ranglistaIdeiglenes.txt", false, Encoding.UTF8);
                        foreach (var std in result)
                        {
                            sw.WriteLine(std.Nev + ";" + std.Szint + ";" + std.JatszottMasodperc);
                        }
                        sw.Close();
                        List<string> ideiglenesLista = new List<string>();
                        StreamReader sre = new StreamReader("ranglistaIdeiglenes.txt", Encoding.UTF8);
                        while (!sre.EndOfStream)
                        {
                            ideiglenesLista.Add(sre.ReadLine());
                        }

                        string csere = ideiglenesLista[0];
                        sor[sor.Count - 1] = csere;
                        sre.Close();
                        File.Delete("ranglistaIdeiglenes.txt");
                        StreamWriter swr = new StreamWriter("ranglista.txt", false, Encoding.UTF8);
                        foreach (var item in sor)
                        {
                            swr.WriteLine(item);
                        }
                        swr.Close();
                        File.Delete("ranglista.txt");
                        rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[0]),
                            new Helyezes(sor[1]),
                            new Helyezes(sor[2]),
                            new Helyezes(nev,szintLocal,jatekIdo)
                        };
                        var result2 = rangLista.OrderByDescending(r => r.Szint).ThenBy(r => r.JatszottMasodperc);
                        StreamWriter asd = new StreamWriter("ranglista.txt", false, Encoding.UTF8);
                        foreach (var std in result2)
                        {
                            asd.WriteLine(std.Nev + ";" + std.Szint + ";" + std.JatszottMasodperc);
                        }
                        asd.Close();
                    }
                }
                else
                {
                    StreamWriter sw = new StreamWriter("ranglista.txt", false, Encoding.UTF8);
                    sw.WriteLine("{0};{1};{2}", nev, szintLocal, jatekIdo);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void uzenet(string uzenet, string fejlec)
        {
            tmr_Timer.Enabled = false;
            tmr_idomeres.Enabled = false;
            MessageBox.Show(uzenet, fejlec);
            bttn_UjJatek.Text = "Új játék";
            nmrcUpDown_SorDb.Enabled = true;
            cmbBx_nehezseg.Enabled = true;
            if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                idomeres = lapokSzama * 10;
            else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                idomeres = lapokSzama * 5;
            else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                idomeres = lapokSzama * 2;
            tmr_idomeres.Enabled = true;
            fp_Panel.Controls.Clear();
            //megjelenites();          
        }

        private void sorszamSorsol()
        {
            sorSzamok = new List<int>();
            while (sorSzamok.Count < lapokSzama)
            {
                int kovSorszam = r.Next(1, maxKep + 1);
                if (!sorSzamok.Contains(kovSorszam))
                {
                    sorSzamok.Add(kovSorszam);
                    sorSzamok.Add(kovSorszam);
                }
            }
        }

        private void kever()
        {
            int lap1;
            int lap2;
            for (int i = 0; i < 100; i++)
            {
                do
                {
                    lap1 = r.Next(1, sorSzamok.Count);
                    lap2 = r.Next(1, sorSzamok.Count);
                    if (lap1 != lap2)
                    {
                        void csere() => (sorSzamok[lap1], sorSzamok[lap2]) = (sorSzamok[lap2], sorSzamok[lap1]);
                        csere();
                    }
                }
                while (lap1 == lap2);
            }
        }

        private void megjelenites()
        {
            Lap.LevettParokSzama = 0;
            probalkozasokSzama = 0;
            lbl_LevettParok.Text = "Levett párok: " + Lap.LevettParokSzama;
            sorokSzama = (int)nmrcUpDown_SorDb.Value;
            lapokSzama = (int)Math.Pow(sorokSzama, 2);
            sorszamSorsol();
            kever();
            fp_Panel.Controls.Clear();
            foreach (var item in sorSzamok)
            {
                fp_Panel.Controls.Add(new Lap(item, fp_Panel.Width / sorokSzama));
            }
            if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                lbl_probalkozasok.Text = "Rendelkezésre álló próbálkozások száma: " + ((lapokSzama * 10) - probalkozasokSzama);
            else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                lbl_probalkozasok.Text = "Rendelkezésre álló próbálkozások száma: " + ((lapokSzama * 5) - probalkozasokSzama);
            else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                lbl_probalkozasok.Text = "Rendelkezésre álló próbálkozások száma: " + ((lapokSzama * 1.5) - probalkozasokSzama);

        }

        private void bttn_UjJatek_Click(object sender, EventArgs e)
        {
            if (bttn_UjJatek.Text == "Leállít")
            {
                foreach (Lap item in fp_Panel.Controls)
                {
                    if (!item.Megforditva)
                        item.fordit();
                }
                Lap.LevettParokSzama = 0;
                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                    idomeres = lapokSzama * 10;
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                    idomeres = lapokSzama * 5;
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                    idomeres = lapokSzama * 2;
                probalkozasokSzama = 0;
                nmrcUpDown_SorDb.Enabled = true;
                cmbBx_nehezseg.Enabled = true;
                bttn_UjJatek.Text = "Új játék";
            }
            else
            {
                if (cmbBx_nehezseg.SelectedItem == null)
                    MessageBox.Show("Válasszon szintet!", "Szint");
                else
                {
                    nmrcUpDown_SorDb.Enabled = false;
                    cmbBx_nehezseg.Enabled = false;
                    megjelenites();
                    bttn_UjJatek.Text = "Leállít";
                    tmr_idomeres.Enabled = true;
                    if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                        idomeres = lapokSzama * 10;
                    else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                        idomeres = lapokSzama * 5;
                    else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                        idomeres = lapokSzama * 2;
                }

                
            }
        }

        private void tmr_Timer_Tick(object sender, EventArgs e)
        {
            probalkozasokSzama++;
            if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                lbl_probalkozasok.Text = "Rendelkezésre álló próbálkozások száma: " + ((lapokSzama * 10) - probalkozasokSzama);
            else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                lbl_probalkozasok.Text = "Rendelkezésre álló próbálkozások száma: " + ((lapokSzama * 5) - probalkozasokSzama);
            else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                lbl_probalkozasok.Text = "Rendelkezésre álló próbálkozások száma: " + ((lapokSzama * 1.5) - probalkozasokSzama);

            if (Lap.Levenni && Lap.ElozoLap != Lap.AktualisLap)
            {
                Lap.ElozoLap.levesz();
                Lap.AktualisLap.levesz();
                Lap.LevettParokSzama++;
                lbl_LevettParok.Text = "Levett párok: " + Lap.LevettParokSzama;
                if (Lap.LevettParokSzama == (lapokSzama / 2))
                {
                    uzenet("Gratulálok, minden lapot levett!!","Gratulálok!");
                    ranglista();
                }
            }
            else
            {
                Lap.ElozoLap.fordit();
                Lap.AktualisLap.fordit();
                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű") && probalkozasokSzama >= lapokSzama * 10)
                {
                    uzenet("Sajnálom, de nem tudta teljesíteni ezt a szintet!!","Elfogyott próbálkozások");
                }
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes") && probalkozasokSzama >= lapokSzama * 5)
                {
                    uzenet("Sajnálom, de nem tudta teljesíteni ezt a szintet!!", "Elfogyott próbálkozások");
                }
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz") && probalkozasokSzama >= lapokSzama * 1.5)
                {
                    uzenet("Sajnálom, de nem tudta teljesíteni ezt a szintet!!", "Elfogyott próbálkozások");
                }
            }
            tmr_Timer.Enabled = false;
            Lap.MegforditottLapokSzama = 0;
        }

        private void tmr_idomeres_Tick(object sender, EventArgs e)
        {
            if (bttn_UjJatek.Text == "Leállít")
            {
                idomeres--;
                lbl_ido.Text = "Játékidő: " + idomeres;
                if (idomeres == 0)
                {
                    uzenet("Sajnálom, de nem tudta teljesíteni ezt a szintet!!", "Lejárt az idő");
                }
                jatekido++;
            }
            else
            {
                jatekido = 0;
            }
        }

        private void ranglistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }           
        }
    }
}
