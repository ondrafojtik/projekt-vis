namespace VIS
{
    partial class FormKontaktovaniStudenta
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
            this.textbox_id_studenta = new System.Windows.Forms.TextBox();
            this.combobox_seznam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_kontaktovat_rodice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selected_email = new System.Windows.Forms.Label();
            this.selected_prijmeni = new System.Windows.Forms.Label();
            this.selected_jmeno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_odeslat = new System.Windows.Forms.Button();
            this.textbox_obsah_zpravy = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_id_studenta
            // 
            this.textbox_id_studenta.Location = new System.Drawing.Point(22, 33);
            this.textbox_id_studenta.Name = "textbox_id_studenta";
            this.textbox_id_studenta.Size = new System.Drawing.Size(91, 23);
            this.textbox_id_studenta.TabIndex = 0;
            this.textbox_id_studenta.TextChanged += new System.EventHandler(this.textbox_id_studenta_TextChanged);
            // 
            // combobox_seznam
            // 
            this.combobox_seznam.FormattingEnabled = true;
            this.combobox_seznam.Location = new System.Drawing.Point(139, 32);
            this.combobox_seznam.Name = "combobox_seznam";
            this.combobox_seznam.Size = new System.Drawing.Size(121, 23);
            this.combobox_seznam.TabIndex = 1;
            this.combobox_seznam.SelectedIndexChanged += new System.EventHandler(this.combobox_seznam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vybrat ze seznamu";
            // 
            // button_kontaktovat_rodice
            // 
            this.button_kontaktovat_rodice.Location = new System.Drawing.Point(279, 31);
            this.button_kontaktovat_rodice.Name = "button_kontaktovat_rodice";
            this.button_kontaktovat_rodice.Size = new System.Drawing.Size(191, 23);
            this.button_kontaktovat_rodice.TabIndex = 3;
            this.button_kontaktovat_rodice.Text = "Kontaktovat rodice";
            this.button_kontaktovat_rodice.UseVisualStyleBackColor = true;
            this.button_kontaktovat_rodice.Click += new System.EventHandler(this.button_kontaktovat_rodice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selected_email);
            this.groupBox1.Controls.Add(this.selected_prijmeni);
            this.groupBox1.Controls.Add(this.selected_jmeno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // selected_email
            // 
            this.selected_email.AutoSize = true;
            this.selected_email.Location = new System.Drawing.Point(61, 59);
            this.selected_email.Name = "selected_email";
            this.selected_email.Size = new System.Drawing.Size(0, 15);
            this.selected_email.TabIndex = 5;
            // 
            // selected_prijmeni
            // 
            this.selected_prijmeni.AutoSize = true;
            this.selected_prijmeni.Location = new System.Drawing.Point(60, 44);
            this.selected_prijmeni.Name = "selected_prijmeni";
            this.selected_prijmeni.Size = new System.Drawing.Size(0, 15);
            this.selected_prijmeni.TabIndex = 4;
            // 
            // selected_jmeno
            // 
            this.selected_jmeno.AutoSize = true;
            this.selected_jmeno.Location = new System.Drawing.Point(61, 29);
            this.selected_jmeno.Name = "selected_jmeno";
            this.selected_jmeno.Size = new System.Drawing.Size(0, 15);
            this.selected_jmeno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prijmeni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jmeno: ";
            // 
            // button_odeslat
            // 
            this.button_odeslat.Location = new System.Drawing.Point(22, 292);
            this.button_odeslat.Name = "button_odeslat";
            this.button_odeslat.Size = new System.Drawing.Size(200, 60);
            this.button_odeslat.TabIndex = 5;
            this.button_odeslat.Text = "Odeslat";
            this.button_odeslat.UseVisualStyleBackColor = true;
            this.button_odeslat.Click += new System.EventHandler(this.button_odeslat_Click);
            // 
            // textbox_obsah_zpravy
            // 
            this.textbox_obsah_zpravy.Location = new System.Drawing.Point(279, 127);
            this.textbox_obsah_zpravy.Multiline = true;
            this.textbox_obsah_zpravy.Name = "textbox_obsah_zpravy";
            this.textbox_obsah_zpravy.Size = new System.Drawing.Size(412, 225);
            this.textbox_obsah_zpravy.TabIndex = 6;
            // 
            // FormKontaktovaniStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox_obsah_zpravy);
            this.Controls.Add(this.button_odeslat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_kontaktovat_rodice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_seznam);
            this.Controls.Add(this.textbox_id_studenta);
            this.Name = "FormKontaktovaniStudenta";
            this.Text = "FormZadatZnamku";
            this.Load += new System.EventHandler(this.FormZadatZnamku_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textbox_id_studenta;
        private System.Windows.Forms.ComboBox combobox_seznam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_kontaktovat_rodice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_odeslat;
        private System.Windows.Forms.TextBox textbox_obsah_zpravy;
        private System.Windows.Forms.Label selected_email;
        private System.Windows.Forms.Label selected_prijmeni;
        private System.Windows.Forms.Label selected_jmeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}