using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class Lap : PictureBox
    {
        private int sorszam;
        private bool megforditva;

        private static int megforditottLapokSzama = 0;
        private static int levettParokSzama = 0;
        private static Lap elozoLap = null;
        private static Lap aktualisLap = null;
        private static bool levenni = false;

        public Lap(int sorszam, int meret)
        {
            this.sorszam = sorszam;
            this.Width = meret;
            this.Height = meret;
            this.Image = Image.FromFile("Kepek//hatlap.jpg");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Margin = new Padding(0, 0, 0, 0);
            this.megforditva = false;
            this.Click += Lap_Click;
        }
        public static int MegforditottLapokSzama { get => megforditottLapokSzama; set => megforditottLapokSzama = value; }
        public static int LevettParokSzama { get => levettParokSzama; set => levettParokSzama = value; }
        internal static Lap ElozoLap { get => elozoLap; set => elozoLap = value; }
        internal static Lap AktualisLap { get => aktualisLap; set => aktualisLap = value; }
        public static bool Levenni { get => levenni; set => levenni = value; }
        private void Lap_Click(object sender, EventArgs e)
        {
            if (MegforditottLapokSzama<2)
            {
                fordit();
                MegforditottLapokSzama++;
                if (MegforditottLapokSzama==1)
                    ElozoLap = this;
                else if (MegforditottLapokSzama==2)
                {
                    AktualisLap = this;
                    if (AktualisLap.sorszam == ElozoLap.sorszam)
                        Levenni = true;
                    else
                        Levenni = false;
                    (this.Parent.Parent as FrmMemory).tmr_Timer.Enabled = true;
                }
            }
        }

        public void fordit()
        {
            megforditva = !megforditva;
            this.Image = Image.FromFile("Kepek//" + (megforditva ? sorszam + "" : "hatlap") + ".jpg");
        }

        public void levesz()
        {
            this.Image = Image.FromFile("Kepek/Ures.jpg");
        }
    }
}
