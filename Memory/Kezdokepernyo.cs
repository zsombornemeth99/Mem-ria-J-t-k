using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Kezdokepernyo : Form
    {
        private string nev;

        public Kezdokepernyo()
        {
            InitializeComponent();
        }

        public string Nev { get => nev; set => nev = value; }

        private void bttn_tovabb_Click(object sender, EventArgs e)
        {
            if (txtBx_nev.Text.Length >= 3 && txtBx_nev.Text.Length <= 10)
            {
                nev = txtBx_nev.Text;
                this.Hide();
                FrmMemory f = new FrmMemory(nev);
                f.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("A névnek minimum 3, maximum 10 betűsnek kell lennie!", "Hiba!");
        }
    }
}
