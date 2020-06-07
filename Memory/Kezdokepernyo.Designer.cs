namespace Memory
{
    partial class Kezdokepernyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kezdokepernyo));
            this.lbl_udvozles = new System.Windows.Forms.Label();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.txtBx_nev = new System.Windows.Forms.TextBox();
            this.bttn_tovabb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_udvozles
            // 
            this.lbl_udvozles.AutoSize = true;
            this.lbl_udvozles.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_udvozles.ForeColor = System.Drawing.Color.Red;
            this.lbl_udvozles.Location = new System.Drawing.Point(12, 24);
            this.lbl_udvozles.Name = "lbl_udvozles";
            this.lbl_udvozles.Size = new System.Drawing.Size(415, 38);
            this.lbl_udvozles.TabIndex = 0;
            this.lbl_udvozles.Text = "Köszöntöm a memória játékban!";
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nev.ForeColor = System.Drawing.Color.Red;
            this.lbl_nev.Location = new System.Drawing.Point(12, 119);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(323, 38);
            this.lbl_nev.TabIndex = 0;
            this.lbl_nev.Text = "Kérem adja meg a nevét:";
            // 
            // txtBx_nev
            // 
            this.txtBx_nev.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBx_nev.Location = new System.Drawing.Point(341, 116);
            this.txtBx_nev.Name = "txtBx_nev";
            this.txtBx_nev.Size = new System.Drawing.Size(273, 43);
            this.txtBx_nev.TabIndex = 1;
            this.txtBx_nev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBx_nev_KeyDown);
            // 
            // bttn_tovabb
            // 
            this.bttn_tovabb.Location = new System.Drawing.Point(457, 200);
            this.bttn_tovabb.Name = "bttn_tovabb";
            this.bttn_tovabb.Size = new System.Drawing.Size(157, 42);
            this.bttn_tovabb.TabIndex = 2;
            this.bttn_tovabb.Text = "Tovább";
            this.bttn_tovabb.UseVisualStyleBackColor = true;
            this.bttn_tovabb.Click += new System.EventHandler(this.bttn_tovabb_Click);
            // 
            // Kezdokepernyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 265);
            this.Controls.Add(this.bttn_tovabb);
            this.Controls.Add(this.txtBx_nev);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.lbl_udvozles);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kezdokepernyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üdvözlés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_udvozles;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.TextBox txtBx_nev;
        private System.Windows.Forms.Button bttn_tovabb;
    }
}