using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private int probalkozasokSzama;

        private Random r = new Random();
        private List<int> sorSzamok;

        public FrmMemory()
        {
            InitializeComponent();
            //megjelenites();
        }

        private void uzenet(bool gratulalVagySajnal)
        {
            if (gratulalVagySajnal)
            {
                tmr_Timer.Enabled = false;
                tmr_idomeres.Enabled = false;
                MessageBox.Show("Gratulálok, minden lapot levett!!", "Gratulálok!");
                bttn_UjJatek.Text = "Új játék";
                nmrcUpDown_SorDb.Enabled = true;
                cmbBx_nehezseg.Enabled = true;
                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                    idomeres = lapokSzama*10;
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                    idomeres = lapokSzama * 5;
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                    idomeres = lapokSzama * 2;
                tmr_idomeres.Enabled = true;
                fp_Panel.Controls.Clear();
                //megjelenites();
            }
            else
            {
                tmr_Timer.Enabled = false;
                tmr_idomeres.Enabled = false;
                MessageBox.Show("Sajnálom, de nem tudta teljesíteni ezt a szintet!!", "Nem sikerült!");
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
            }
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
                if (cmbBx_nehezseg.SelectedItem==null)
                    MessageBox.Show("Válasszon szintet!", "Szint");
                else
                {
                    nmrcUpDown_SorDb.Enabled = false;
                    cmbBx_nehezseg.Enabled = false;
                    megjelenites();
                    bttn_UjJatek.Text = "Leállít";
                    tmr_idomeres.Enabled = true;
                }

                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű"))
                    idomeres = lapokSzama * 10;
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes"))
                    idomeres = lapokSzama * 5;
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz"))
                    idomeres = lapokSzama * 2;
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
                    uzenet(true);
                }
            }
            else
            {
                Lap.ElozoLap.fordit();
                Lap.AktualisLap.fordit();
                if (cmbBx_nehezseg.SelectedItem.Equals("Könnyű") && probalkozasokSzama >= lapokSzama*10)
                {
                    uzenet(false);
                }
                else if (cmbBx_nehezseg.SelectedItem.Equals("Közepes") && probalkozasokSzama >= lapokSzama * 5)
                {
                    uzenet(false);
                }
                else if (cmbBx_nehezseg.SelectedItem.Equals("Nehéz") && probalkozasokSzama >= lapokSzama * 1.5)
                {
                    uzenet(false);
                }
            }            
            tmr_Timer.Enabled = false;
            Lap.MegforditottLapokSzama = 0;            
        }

        private void tmr_idomeres_Tick(object sender, EventArgs e)
        {
            if (bttn_UjJatek.Text == "Leállít")
            {               
                lbl_ido.Text = "Játékidő: " + idomeres;
                idomeres--;
                if (idomeres == 0)
                {
                    uzenet(false);
                }
            }
        }        
    }
}
