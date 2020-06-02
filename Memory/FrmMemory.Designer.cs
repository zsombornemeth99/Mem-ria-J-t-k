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
            this.fp_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_SorOszlop = new System.Windows.Forms.Panel();
            this.bttn_UjJatek = new System.Windows.Forms.Button();
            this.nmrcUpDown_SorDb = new System.Windows.Forms.NumericUpDown();
            this.lbl_SorOszlop = new System.Windows.Forms.Label();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_LevettParok = new System.Windows.Forms.Label();
            this.tmr_Timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_ido = new System.Windows.Forms.Label();
            this.tmr_idomeres = new System.Windows.Forms.Timer(this.components);
            this.pnl_SorOszlop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDown_SorDb)).BeginInit();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // fp_Panel
            // 
            this.fp_Panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fp_Panel.Location = new System.Drawing.Point(12, 12);
            this.fp_Panel.Name = "fp_Panel";
            this.fp_Panel.Size = new System.Drawing.Size(533, 480);
            this.fp_Panel.TabIndex = 0;
            // 
            // pnl_SorOszlop
            // 
            this.pnl_SorOszlop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SorOszlop.Controls.Add(this.bttn_UjJatek);
            this.pnl_SorOszlop.Controls.Add(this.nmrcUpDown_SorDb);
            this.pnl_SorOszlop.Controls.Add(this.lbl_SorOszlop);
            this.pnl_SorOszlop.Location = new System.Drawing.Point(592, 12);
            this.pnl_SorOszlop.Name = "pnl_SorOszlop";
            this.pnl_SorOszlop.Size = new System.Drawing.Size(229, 118);
            this.pnl_SorOszlop.TabIndex = 1;
            // 
            // bttn_UjJatek
            // 
            this.bttn_UjJatek.Location = new System.Drawing.Point(20, 67);
            this.bttn_UjJatek.Name = "bttn_UjJatek";
            this.bttn_UjJatek.Size = new System.Drawing.Size(178, 31);
            this.bttn_UjJatek.TabIndex = 2;
            this.bttn_UjJatek.Text = "Új játék";
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
            this.nmrcUpDown_SorDb.Location = new System.Drawing.Point(141, 26);
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
            this.nmrcUpDown_SorDb.Size = new System.Drawing.Size(57, 22);
            this.nmrcUpDown_SorDb.TabIndex = 1;
            this.nmrcUpDown_SorDb.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbl_SorOszlop
            // 
            this.lbl_SorOszlop.AutoSize = true;
            this.lbl_SorOszlop.Location = new System.Drawing.Point(17, 28);
            this.lbl_SorOszlop.Name = "lbl_SorOszlop";
            this.lbl_SorOszlop.Size = new System.Drawing.Size(78, 17);
            this.lbl_SorOszlop.TabIndex = 0;
            this.lbl_SorOszlop.Text = "Sor/Oszlop";
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Footer.Controls.Add(this.lbl_ido);
            this.pnl_Footer.Controls.Add(this.lbl_LevettParok);
            this.pnl_Footer.Location = new System.Drawing.Point(0, 532);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(833, 37);
            this.pnl_Footer.TabIndex = 2;
            // 
            // lbl_LevettParok
            // 
            this.lbl_LevettParok.AutoSize = true;
            this.lbl_LevettParok.Location = new System.Drawing.Point(686, 10);
            this.lbl_LevettParok.Name = "lbl_LevettParok";
            this.lbl_LevettParok.Size = new System.Drawing.Size(91, 17);
            this.lbl_LevettParok.TabIndex = 0;
            this.lbl_LevettParok.Text = "Levett párok:";
            // 
            // tmr_Timer
            // 
            this.tmr_Timer.Interval = 1000;
            this.tmr_Timer.Tick += new System.EventHandler(this.tmr_Timer_Tick);
            // 
            // lbl_ido
            // 
            this.lbl_ido.AutoSize = true;
            this.lbl_ido.Location = new System.Drawing.Point(11, 10);
            this.lbl_ido.Name = "lbl_ido";
            this.lbl_ido.Size = new System.Drawing.Size(65, 17);
            this.lbl_ido.TabIndex = 1;
            this.lbl_ido.Text = "Játékidő:";
            // 
            // tmr_idomeres
            // 
            this.tmr_idomeres.Enabled = true;
            this.tmr_idomeres.Interval = 1000;
            this.tmr_idomeres.Tick += new System.EventHandler(this.tmr_idomeres_Tick);
            // 
            // FrmMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 569);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_SorOszlop);
            this.Controls.Add(this.fp_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memória Játék";
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
    }
}

