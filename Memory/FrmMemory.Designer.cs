namespace Memory
{
    partial class FrmMemory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemory));
            this.fp_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_SorOszlop = new System.Windows.Forms.Panel();
            this.lbl_udv = new System.Windows.Forms.Label();
            this.cmbBx_nehezseg = new System.Windows.Forms.ComboBox();
            this.bttn_UjJatek = new System.Windows.Forms.Button();
            this.nmrcUpDown_SorDb = new System.Windows.Forms.NumericUpDown();
            this.lbl_nehezseg = new System.Windows.Forms.Label();
            this.lbl_SorOszlop = new System.Windows.Forms.Label();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_probalkozasok = new System.Windows.Forms.Label();
            this.lbl_ido = new System.Windows.Forms.Label();
            this.lbl_LevettParok = new System.Windows.Forms.Label();
            this.tmr_Timer = new System.Windows.Forms.Timer(this.components);
            this.tmr_idomeres = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.ranglistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ranglistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.szintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.közepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nehézToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_SorOszlop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDown_SorDb)).BeginInit();
            this.pnl_Footer.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fp_Panel
            // 
            this.fp_Panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.fp_Panel, "fp_Panel");
            this.fp_Panel.Name = "fp_Panel";
            // 
            // pnl_SorOszlop
            // 
            this.pnl_SorOszlop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SorOszlop.Controls.Add(this.lbl_udv);
            this.pnl_SorOszlop.Controls.Add(this.cmbBx_nehezseg);
            this.pnl_SorOszlop.Controls.Add(this.bttn_UjJatek);
            this.pnl_SorOszlop.Controls.Add(this.nmrcUpDown_SorDb);
            this.pnl_SorOszlop.Controls.Add(this.lbl_nehezseg);
            this.pnl_SorOszlop.Controls.Add(this.lbl_SorOszlop);
            resources.ApplyResources(this.pnl_SorOszlop, "pnl_SorOszlop");
            this.pnl_SorOszlop.Name = "pnl_SorOszlop";
            // 
            // lbl_udv
            // 
            resources.ApplyResources(this.lbl_udv, "lbl_udv");
            this.lbl_udv.Name = "lbl_udv";
            // 
            // cmbBx_nehezseg
            // 
            this.cmbBx_nehezseg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBx_nehezseg.FormattingEnabled = true;
            this.cmbBx_nehezseg.Items.AddRange(new object[] {
            resources.GetString("cmbBx_nehezseg.Items"),
            resources.GetString("cmbBx_nehezseg.Items1"),
            resources.GetString("cmbBx_nehezseg.Items2")});
            resources.ApplyResources(this.cmbBx_nehezseg, "cmbBx_nehezseg");
            this.cmbBx_nehezseg.Name = "cmbBx_nehezseg";
            // 
            // bttn_UjJatek
            // 
            resources.ApplyResources(this.bttn_UjJatek, "bttn_UjJatek");
            this.bttn_UjJatek.Name = "bttn_UjJatek";
            this.bttn_UjJatek.UseVisualStyleBackColor = true;
            this.bttn_UjJatek.Click += new System.EventHandler(this.bttn_UjJatek_Click);
            // 
            // nmrcUpDown_SorDb
            // 
            this.nmrcUpDown_SorDb.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            resources.ApplyResources(this.nmrcUpDown_SorDb, "nmrcUpDown_SorDb");
            this.nmrcUpDown_SorDb.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrcUpDown_SorDb.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmrcUpDown_SorDb.Name = "nmrcUpDown_SorDb";
            this.nmrcUpDown_SorDb.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbl_nehezseg
            // 
            resources.ApplyResources(this.lbl_nehezseg, "lbl_nehezseg");
            this.lbl_nehezseg.Name = "lbl_nehezseg";
            // 
            // lbl_SorOszlop
            // 
            resources.ApplyResources(this.lbl_SorOszlop, "lbl_SorOszlop");
            this.lbl_SorOszlop.Name = "lbl_SorOszlop";
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Footer.Controls.Add(this.lbl_probalkozasok);
            this.pnl_Footer.Controls.Add(this.lbl_ido);
            this.pnl_Footer.Controls.Add(this.lbl_LevettParok);
            resources.ApplyResources(this.pnl_Footer, "pnl_Footer");
            this.pnl_Footer.Name = "pnl_Footer";
            // 
            // lbl_probalkozasok
            // 
            resources.ApplyResources(this.lbl_probalkozasok, "lbl_probalkozasok");
            this.lbl_probalkozasok.Name = "lbl_probalkozasok";
            // 
            // lbl_ido
            // 
            resources.ApplyResources(this.lbl_ido, "lbl_ido");
            this.lbl_ido.Name = "lbl_ido";
            // 
            // lbl_LevettParok
            // 
            resources.ApplyResources(this.lbl_LevettParok, "lbl_LevettParok");
            this.lbl_LevettParok.Name = "lbl_LevettParok";
            // 
            // tmr_Timer
            // 
            this.tmr_Timer.Interval = 1000;
            this.tmr_Timer.Tick += new System.EventHandler(this.tmr_Timer_Tick);
            // 
            // tmr_idomeres
            // 
            this.tmr_idomeres.Enabled = true;
            this.tmr_idomeres.Interval = 1000;
            this.tmr_idomeres.Tick += new System.EventHandler(this.tmr_idomeres_Tick);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ranglistaToolStripMenuItem});
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // ranglistaToolStripMenuItem
            // 
            this.ranglistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ranglistaToolStripMenuItem1});
            this.ranglistaToolStripMenuItem.Name = "ranglistaToolStripMenuItem";
            resources.ApplyResources(this.ranglistaToolStripMenuItem, "ranglistaToolStripMenuItem");
            // 
            // ranglistaToolStripMenuItem1
            // 
            this.ranglistaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szintToolStripMenuItem,
            this.közepesToolStripMenuItem,
            this.nehézToolStripMenuItem});
            this.ranglistaToolStripMenuItem1.Name = "ranglistaToolStripMenuItem1";
            resources.ApplyResources(this.ranglistaToolStripMenuItem1, "ranglistaToolStripMenuItem1");
            // 
            // szintToolStripMenuItem
            // 
            this.szintToolStripMenuItem.Name = "szintToolStripMenuItem";
            resources.ApplyResources(this.szintToolStripMenuItem, "szintToolStripMenuItem");
            this.szintToolStripMenuItem.Click += new System.EventHandler(this.szintToolStripMenuItem_Click);
            // 
            // közepesToolStripMenuItem
            // 
            this.közepesToolStripMenuItem.Name = "közepesToolStripMenuItem";
            resources.ApplyResources(this.közepesToolStripMenuItem, "közepesToolStripMenuItem");
            this.közepesToolStripMenuItem.Click += new System.EventHandler(this.közepesToolStripMenuItem_Click);
            // 
            // nehézToolStripMenuItem
            // 
            this.nehézToolStripMenuItem.Name = "nehézToolStripMenuItem";
            resources.ApplyResources(this.nehézToolStripMenuItem, "nehézToolStripMenuItem");
            this.nehézToolStripMenuItem.Click += new System.EventHandler(this.nehézToolStripMenuItem_Click);
            // 
            // FrmMemory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_SorOszlop);
            this.Controls.Add(this.fp_Panel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "FrmMemory";
            this.pnl_SorOszlop.ResumeLayout(false);
            this.pnl_SorOszlop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDown_SorDb)).EndInit();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fp_Panel;
        private System.Windows.Forms.Panel pnl_SorOszlop;
        private System.Windows.Forms.Label lbl_SorOszlop;
        private System.Windows.Forms.NumericUpDown nmrcUpDown_SorDb;
        private System.Windows.Forms.Button bttn_UjJatek;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_LevettParok;
        public System.Windows.Forms.Timer tmr_Timer;
        private System.Windows.Forms.Label lbl_ido;
        private System.Windows.Forms.Timer tmr_idomeres;
        private System.Windows.Forms.ComboBox cmbBx_nehezseg;
        private System.Windows.Forms.Label lbl_nehezseg;
        private System.Windows.Forms.Label lbl_probalkozasok;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem ranglistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ranglistaToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_udv;
        private System.Windows.Forms.ToolStripMenuItem szintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem közepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nehézToolStripMenuItem;
    }
}

