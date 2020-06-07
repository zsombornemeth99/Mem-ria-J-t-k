using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Ranglista : Form
    {
        private string nev;

        public string Nev { get => nev; set => nev = value; }

        public Ranglista(string nev,string szint, int SorOszlop)
        {
            this.nev = nev;
            InitializeComponent();
            ranglistaMegjelenites(szint,SorOszlop);
        }

        private void újJátékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMemory f = new FrmMemory(this.nev);
            f.ShowDialog();
            this.Close();
        }

        private void bttn_vissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMemory f = new FrmMemory(this.nev);
            f.ShowDialog();
            this.Close();
        }

        private void ranglistaMegjelenites(string szint, int SorOszlop)
        {
            // beolvasás, kilistázás
            List<string> rang = new List<string>();
            try
            {
                StreamReader r = new StreamReader("ranglista"+szint+SorOszlop+".txt", Encoding.UTF8);
                while (!r.EndOfStream)
                {
                    string sor = r.ReadLine();
                    rang.Add(sor);
                }
                r.Close();
                string[] adatok;
                List<string> nev = new List<string>();
                List<int> eredmeny = new List<int>();
                List<long> ido = new List<long>();
                List<int> levettParok = new List<int>();
                foreach (var item in rang)
                {
                    adatok = item.Split(';');
                    nev.Add(adatok[0]);
                    eredmeny.Add(int.Parse(adatok[1]));
                    ido.Add(long.Parse(adatok[2]));
                    levettParok.Add(int.Parse(adatok[3]));
                }
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        lbl_elso.Text = "1.";
                        lbl_elsoNev.Text = "" + nev[i];
                        lbl_elsoSzint.Text ="" +eredmeny[i];
                        lbl_elsoIdo.Text =ido[i]+" mp";
                        lbl_elsoLevett.Text ="" + levettParok[i];
                    }
                    try
                    {
                        if (i == 1)
                        {
                            lbl_masodik.Text = "2.";
                            lbl_masodikNev.Text = "" + nev[i];
                            lbl_masodikSzint.Text = ""+eredmeny[i];
                            lbl_masodikIdo.Text = ido[i] + " mp";
                            lbl_masodikLevett.Text = "" + levettParok[i];
                        }
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        if (i == 2)
                        {
                            lbl_harmadik.Text = "3.";
                            lbl_harmadikNev.Text = "" + nev[i];
                            lbl_harmadikSzint.Text = ""+eredmeny[i];
                            lbl_harmadikIdo.Text = ido[i] + " mp";
                            lbl_harmadikLevett.Text = "" + levettParok[i];
                        }
                    }
                    catch (Exception)
                    {

                    }

                }              
            }
            catch (FileNotFoundException)
            {                
                MessageBox.Show("Még nem jött létre ranglista!");
                this.Hide();
                FrmMemory f = new FrmMemory(this.nev);
                f.ShowDialog();
                this.Close();
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
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
