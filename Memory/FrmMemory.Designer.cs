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
            this.bttn_UjJatek = new System.Windows.Forms.Button();
            this.nmrcUpDown_SorDb = new System.Windows.Forms.NumericUpDown();
            this.lbl_SorOszlop = new System.Windows.Forms.Label();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_ido = new System.Windows.Forms.Label();
            this.lbl_LevettParok = new System.Windows.Forms.Label();
            this.tmr_Timer = new System.Windows.Forms.Timer(this.components);
            this.tmr_idomeres = new System.Windows.Forms.Timer(this.components);
            this.lbl_nehezseg = new System.Windows.Forms.Label();
            this.cmbBx_nehezseg = new System.Windows.Forms.ComboBox();
            this.lbl_probalkozasok = new System.Windows.Forms.Label();
            this.pnl_SorOszlop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDown_SorDb)).BeginInit();
            this.pnl_Footer.SuspendLayout();
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
            this.pnl_SorOszlop.Controls.Add(this.cmbBx_nehezseg);
            this.pnl_SorOszlop.Controls.Add(this.bttn_UjJatek);
            this.pnl_SorOszlop.Controls.Add(this.nmrcUpDown_SorDb);
            this.pnl_SorOszlop.Controls.Add(this.lbl_nehezseg);
            this.pnl_SorOszlop.Controls.Add(this.lbl_SorOszlop);
            resources.ApplyResources(this.pnl_SorOszlop, "pnl_SorOszlop");
            this.pnl_SorOszlop.Name = "pnl_SorOszlop";
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
            // lbl_nehezseg
            // 
            resources.ApplyResources(this.lbl_nehezseg, "lbl_nehezseg");
            this.lbl_nehezseg.Name = "lbl_nehezseg";
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
            // lbl_probalkozasok
            // 
            resources.ApplyResources(this.lbl_probalkozasok, "lbl_probalkozasok");
            this.lbl_probalkozasok.Name = "lbl_probalkozasok";
            // 
            // FrmMemory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_SorOszlop);
            this.Controls.Add(this.fp_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMemory";
            this.pnl_SorOszlop.ResumeLayout(false);
            this.pnl_SorOszlop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDown_SorDb)).EndInit();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

