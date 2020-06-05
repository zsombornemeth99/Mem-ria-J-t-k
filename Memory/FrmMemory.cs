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
        private int jatekido = 0;
        private int probalkozasokSzama;
        private string nev;

        private Random r = new Random();
        private List<int> sorSzamok;

        public FrmMemory(string nev)
        {           
            InitializeComponent();
            fp_Panel.Width = 480;
            fp_Panel.Height = 480;
            //megjelenites();
            this.nev = nev;
            lbl_udv.Text += this.nev + "!";
        }
        public FrmMemory()
        {
            InitializeComponent();
            fp_Panel.Width = 480;
            fp_Panel.Height = 480;
            lbl_udv.Text += this.nev + "!";
        }

        private void ranglistaSzintek(string szint, int SorOszlop)
        {
            int probalkozasokSzama = this.probalkozasokSzama;
            string nev = this.nev;
            long jatekIdo = this.jatekido;
            int levettParok = Lap.LevettParokSzama;
            IList<Helyezes> rangLista;
            if (File.Exists("ranglista" + szint + SorOszlop + ".txt"))
            {

                List<string> sor = new List<string>();
                StreamReader sr = new StreamReader("ranglista" + szint + SorOszlop + ".txt", Encoding.UTF8);
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
                            new Helyezes(nev,probalkozasokSzama,jatekIdo,levettParok)
                        };
                    var result = rangLista.OrderByDescending(s => s.LevettParokSzama).ThenBy(s => s.JatszottMasodperc).ThenBy(s => s.ProbalkozasokSzama);
                    StreamWriter sw = new StreamWriter("ranglista" + szint + SorOszlop + ".txt", false, Encoding.UTF8);
                    foreach (var std in result)
                    {
                        sw.WriteLine(String.Format("{0};{1};{2};{3}", std.Nev, std.ProbalkozasokSzama, std.JatszottMasodperc, std.LevettParokSzama));
                    }
                    sw.Close();
                }
                else if (sor.Count == 2)
                {
                    rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[0]),
                            new Helyezes(sor[1]),
                            new Helyezes(nev,probalkozasokSzama,jatekIdo,levettParok)                        };
                    var result = rangLista.OrderByDescending(s => s.LevettParokSzama).ThenBy(s => s.JatszottMasodperc).ThenBy(s => s.ProbalkozasokSzama);
                    StreamWriter sw = new StreamWriter("ranglista" + szint + SorOszlop + ".txt", false, Encoding.UTF8);
                    foreach (var std in result)
                    {
                        sw.WriteLine(String.Format("{0};{1};{2};{3}", std.Nev, std.ProbalkozasokSzama, std.JatszottMasodperc, std.LevettParokSzama));
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
                            new Helyezes(nev,probalkozasokSzama,jatekIdo,levettParok)
                        };
                    var result = rangLista.OrderByDescending(s => s.LevettParokSzama).ThenBy(s => s.JatszottMasodperc).ThenBy(s => s.ProbalkozasokSzama);
                    StreamWriter sw = new StreamWriter("ranglista" + szint + SorOszlop + ".txt", false, Encoding.UTF8);
                    foreach (var std in result)
                    {
                        sw.WriteLine(String.Format("{0};{1};{2};{3}", std.Nev, std.ProbalkozasokSzama, std.JatszottMasodperc, std.LevettParokSzama));
                    }
                    sw.Close();
                }
                else
                {
                    rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[sor.Count-1]),
                            new Helyezes(nev,probalkozasokSzama,jatekIdo,levettParok)
                        };
                    var result = rangLista.OrderByDescending(s => s.LevettParokSzama).ThenBy(s => s.JatszottMasodperc).ThenBy(s => s.ProbalkozasokSzama);
                    StreamWriter sw = new StreamWriter("ranglistaIdeiglenes.txt", false, Encoding.UTF8);
                    foreach (var std in result)
                    {
                        sw.WriteLine(String.Format("{0};{1};{2};{3}", std.Nev, std.ProbalkozasokSzama, std.JatszottMasodperc, std.LevettParokSzama));
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
                    StreamWriter swr = new StreamWriter("ranglista" + szint + SorOszlop + ".txt", false, Encoding.UTF8);
                    foreach (var item in sor)
                    {
                        swr.WriteLine(item);
                    }
                    swr.Close();
                    File.Delete("ranglista" + szint + SorOszlop + ".txt");
                    rangLista = new List<Helyezes>()
                        {
                            new Helyezes(sor[0]),
                            new Helyezes(sor[1]),
                            new Helyezes(sor[2]),
                            new Helyezes(nev,probalkozasokSzama,jatekIdo,levettParok)
                        };
                    var result2 = rangLista.OrderByDescending(s => s.LevettParokSzama).ThenBy(s => s.JatszottMasodperc).ThenBy(s => s.ProbalkozasokSzama);
                    StreamWriter asd = new StreamWriter("ranglista" + szint + SorOszlop + ".txt", false, Encoding.UTF8);
                    foreach (var std in result2)
                    {
                        asd.WriteLine(String.Format("{0};{1};{2};{3}", std.Nev, std.ProbalkozasokSzama, std.JatszottMasodperc, std.LevettParokSzama));
                    }
                    asd.Close();
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter("ranglista" + szint + SorOszlop + ".txt", false, Encoding.UTF8);
                sw.WriteLine("{0};{1};{2};{3}", nev, probalkozasokSzama, jatekIdo, levettParok);
                sw.Close();
            }
        }

        private void ranglista()
        {
            try
            {
                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű") && nmrcUpDown_SorDb.Value.Equals(4))
                    ranglistaSzintek("Konnyu", 4);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű") && nmrcUpDown_SorDb.Value.Equals(6))
                    ranglistaSzintek("Konnyu", 6);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű") && nmrcUpDown_SorDb.Value.Equals(8))
                    ranglistaSzintek("Konnyu", 8);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű") && nmrcUpDown_SorDb.Value.Equals(10))
                    ranglistaSzintek("Konnyu", 10);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes") && nmrcUpDown_SorDb.Value.Equals(4))
                    ranglistaSzintek("Kozepes", 4);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes") && nmrcUpDown_SorDb.Value.Equals(6))
                    ranglistaSzintek("Kozepes", 6);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes") && nmrcUpDown_SorDb.Value.Equals(8))
                    ranglistaSzintek("Kozepes", 8);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes") && nmrcUpDown_SorDb.Value.Equals(10))
                    ranglistaSzintek("Kozepes", 10);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz") && nmrcUpDown_SorDb.Value.Equals(4))
                    ranglistaSzintek("Nehez", 4);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz") && nmrcUpDown_SorDb.Value.Equals(6))
                    ranglistaSzintek("Nehez", 6);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz") && nmrcUpDown_SorDb.Value.Equals(8))
                    ranglistaSzintek("Nehez", 8);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz") && nmrcUpDown_SorDb.Value.Equals(10))
                    ranglistaSzintek("Nehez", 10);
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz") && nmrcUpDown_SorDb.Value.Equals(2))
                    ranglistaSzintek("Nehez", 2);
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
                fp_Panel.Controls.Add(new Lap(item, fp_Panel.Width/ sorokSzama));
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
                    uzenet("Gratulálok, minden lapot levett!!", "Gratulálok!");
                    ranglista();
                }
            }
            else
            {
                Lap.ElozoLap.fordit();
                Lap.AktualisLap.fordit();
                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű") && probalkozasokSzama >= lapokSzama * 10)
                {
                    uzenet("Sajnálom, de nem tudta teljesíteni ezt a szintet!!", "Elfogyott próbálkozások");
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Konnyu", 4);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Konnyu", 6);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Konnyu", 8);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Konnyu", 10);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Kozepes", 4);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Kozepes", 6);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Kozepes", 8);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Kozepes", 10);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Nehez", 4);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Nehez", 6);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Nehez", 8);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev, "Nehez", 10);
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
