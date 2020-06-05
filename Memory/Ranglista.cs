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

        public Ranglista(string nev,string szint)
        {
            this.nev = nev;
            InitializeComponent();
            ranglistaMegjelenites(szint);
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

        private void ranglistaMegjelenites(string szint)
        {
            // beolvasás, kilistázás
            List<string> rang = new List<string>();
            try
            {
                StreamReader r = new StreamReader("ranglista"+szint+".txt", Encoding.UTF8);
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
                foreach (var item in rang)
                {
                    adatok = item.Split(';');
                    nev.Add(adatok[0]);
                    eredmeny.Add(int.Parse(adatok[1]));
                    ido.Add(long.Parse(adatok[2]));
                }
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        lbl_elso.Text = "1.";
                        lbl_elsoNev.Text = "" + nev[i];
                        lbl_elsoSzint.Text ="" +eredmeny[i];
                        lbl_elsoIdo.Text =ido[i]+" mp";
                    }
                    try
                    {
                        if (i == 1)
                        {
                            lbl_masodik.Text = "2.";
                            lbl_masodikNev.Text = "" + nev[i];
                            lbl_masodikSzint.Text = ""+eredmeny[i];
                            lbl_masodikIdo.Text = ido[i] + " mp";
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

        private void könnyűToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev,"Konnyu");
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void közepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev,"Kozepes");
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void nehézToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ranglista r = new Ranglista(this.nev,"Nehez");
                r.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    } 
}
