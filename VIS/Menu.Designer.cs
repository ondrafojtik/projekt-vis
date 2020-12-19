namespace VIS
{
    partial class Menu
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
            this.button_hromadne_pridani_zaku = new System.Windows.Forms.Button();
            this.button_zaslani_hromadneho_emailu = new System.Windows.Forms.Button();
            this.button_kontaktovat_studenta = new System.Windows.Forms.Button();
            this.button_zadat_znamku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_hromadne_pridani_zaku
            // 
            this.button_hromadne_pridani_zaku.Location = new System.Drawing.Point(137, 89);
            this.button_hromadne_pridani_zaku.Name = "button_hromadne_pridani_zaku";
            this.button_hromadne_pridani_zaku.Size = new System.Drawing.Size(137, 123);
            this.button_hromadne_pridani_zaku.TabIndex = 0;
            this.button_hromadne_pridani_zaku.Text = "Hromadne pridani zaku";
            this.button_hromadne_pridani_zaku.UseVisualStyleBackColor = true;
            this.button_hromadne_pridani_zaku.Click += new System.EventHandler(this.button_hromadne_pridani_zaku_Click);
            // 
            // button_zaslani_hromadneho_emailu
            // 
            this.button_zaslani_hromadneho_emailu.Location = new System.Drawing.Point(290, 89);
            this.button_zaslani_hromadneho_emailu.Name = "button_zaslani_hromadneho_emailu";
            this.button_zaslani_hromadneho_emailu.Size = new System.Drawing.Size(137, 123);
            this.button_zaslani_hromadneho_emailu.TabIndex = 0;
            this.button_zaslani_hromadneho_emailu.Text = "Zaslani hromadneho emailu";
            this.button_zaslani_hromadneho_emailu.UseVisualStyleBackColor = true;
            this.button_zaslani_hromadneho_emailu.Click += new System.EventHandler(this.button_zaslani_hromadneho_emailu_Click);
            // 
            // button_kontaktovat_studenta
            // 
            this.button_kontaktovat_studenta.Location = new System.Drawing.Point(137, 229);
            this.button_kontaktovat_studenta.Name = "button_kontaktovat_studenta";
            this.button_kontaktovat_studenta.Size = new System.Drawing.Size(137, 123);
            this.button_kontaktovat_studenta.TabIndex = 0;
            this.button_kontaktovat_studenta.Text = "Kontaktovat studenta";
            this.button_kontaktovat_studenta.UseVisualStyleBackColor = true;
            this.button_kontaktovat_studenta.Click += new System.EventHandler(this.button_kontaktovat_studenta_Click);
            // 
            // button_zadat_znamku
            // 
            this.button_zadat_znamku.Location = new System.Drawing.Point(290, 229);
            this.button_zadat_znamku.Name = "button_zadat_znamku";
            this.button_zadat_znamku.Size = new System.Drawing.Size(137, 123);
            this.button_zadat_znamku.TabIndex = 0;
            this.button_zadat_znamku.Text = "Zadat znamku";
            this.button_zadat_znamku.UseVisualStyleBackColor = true;
            this.button_zadat_znamku.Click += new System.EventHandler(this.button_zadat_znamku_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_zadat_znamku);
            this.Controls.Add(this.button_kontaktovat_studenta);
            this.Controls.Add(this.button_zaslani_hromadneho_emailu);
            this.Controls.Add(this.button_hromadne_pridani_zaku);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button button_hromadne_pridani_zaku;
        private System.Windows.Forms.Button button_zaslani_hromadneho_emailu;
        private System.Windows.Forms.Button button_kontaktovat_studenta;
        private System.Windows.Forms.Button button_zadat_znamku;
    }
}