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

        private Random r = new Random();
        private List<int> sorSzamok;

        public FrmMemory()
        {
            InitializeComponent();
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
                    lap1 = r.Next(1,sorSzamok.Count);
                    lap2 = r.Next(1,sorSzamok.Count);
                    if (lap1 != lap2)
                    {
                        void csere() => (sorSzamok[lap1], sorSzamok[lap2]) = (sorSzamok[lap2], sorSzamok[lap1]);
                        csere();
                    }
                }
                while (lap1 == lap2);
            }                  
        }

        private void bttn_UjJatek_Click(object sender, EventArgs e)
        {
            sorokSzama = (int)nmrcUpDown_SorDb.Value;
            lapokSzama = (int)Math.Pow(sorokSzama, 2);

            sorszamSorsol();
            kever();

            fp_Panel.Controls.Clear();
            foreach (var item in sorSzamok)
            {
                fp_Panel.Controls.Add(new Lap(item, fp_Panel.Width / sorokSzama));
            }
        }

        private void tmr_Timer_Tick(object sender, EventArgs e)
        {
            if (Lap.Levenni && Lap.ElozoLap!=Lap.AktualisLap)
            {
                Lap.ElozoLap.levesz();
                Lap.AktualisLap.levesz();
                Lap.LevettParokSzama++;
                lbl_LevettParok.Text ="Levett párok: " + Lap.LevettParokSzama;
            }
            else
            {
                Lap.ElozoLap.fordit();
                Lap.AktualisLap.fordit();
            }
            tmr_Timer.Enabled = false;
            Lap.MegforditottLapokSzama = 0;
        }
    }
}
