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
        public Ranglista()
        {
            InitializeComponent();           
        }

        private void újJátékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMemory f = new FrmMemory();
            f.ShowDialog();
            this.Close();
        }

        private void bttn_vissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMemory f = new FrmMemory();
            f.ShowDialog();
            this.Close();
        }
    } 
}
