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
            this.sorOszlopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.közepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorOszlopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDown_SorDb)).BeginInit();
            this.pnl_Footer.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fp_Panel
            // 
            this.fp_Panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.fp_Panel, "fp_Panel");
            this.fp_Panel.Name = "fp_Panel";
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
            this.toolStripMenuItem1});
            this.ranglistaToolStripMenuItem1.Name = "ranglistaToolStripMenuItem1";
            resources.ApplyResources(this.ranglistaToolStripMenuItem1, "ranglistaToolStripMenuItem1");
            // 
            // szintToolStripMenuItem
            // 
            this.szintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorOszlopToolStripMenuItem});
            this.szintToolStripMenuItem.Name = "szintToolStripMenuItem";
            resources.ApplyResources(this.szintToolStripMenuItem, "szintToolStripMenuItem");
            // 
            // sorOszlopToolStripMenuItem
            // 
            this.sorOszlopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.sorOszlopToolStripMenuItem.Name = "sorOszlopToolStripMenuItem";
            resources.ApplyResources(this.sorOszlopToolStripMenuItem, "sorOszlopToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // közepesToolStripMenuItem
            // 
            this.közepesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorOszlopToolStripMenuItem1});
            this.közepesToolStripMenuItem.Name = "közepesToolStripMenuItem";
            resources.ApplyResources(this.közepesToolStripMenuItem, "közepesToolStripMenuItem");
            // 
            // sorOszlopToolStripMenuItem1
            // 
            this.sorOszlopToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.sorOszlopToolStripMenuItem1.Name = "sorOszlopToolStripMenuItem1";
            resources.ApplyResources(this.sorOszlopToolStripMenuItem1, "sorOszlopToolStripMenuItem1");
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            resources.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            resources.ApplyResources(this.toolStripMenuItem14, "toolStripMenuItem14");
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_SorOszlop);
            this.panel1.Controls.Add(this.bttn_UjJatek);
            this.panel1.Controls.Add(this.lbl_udv);
            this.panel1.Controls.Add(this.nmrcUpDown_SorDb);
            this.panel1.Controls.Add(this.lbl_nehezseg);
            this.panel1.Controls.Add(this.cmbBx_nehezseg);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // FrmMemory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.fp_Panel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "FrmMemory";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDown_SorDb)).EndInit();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fp_Panel;
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
        private System.Windows.Forms.ToolStripMenuItem sorOszlopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem sorOszlopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.Panel panel1;
    }
}

