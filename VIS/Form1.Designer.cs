namespace VIS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HKZ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.email_display = new System.Windows.Forms.Label();
            this.prijmeni_display = new System.Windows.Forms.Label();
            this.jmeno_display = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_zadat_cestu_k_souboru = new System.Windows.Forms.Button();
            this.button_pridat_studenty_rucne = new System.Windows.Forms.Button();
            this.button_ulozit_zmeny = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(443, 77);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 0;
            this.Button.Text = "Button";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(144, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 334);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // HKZ
            // 
            this.HKZ.Location = new System.Drawing.Point(443, 48);
            this.HKZ.Name = "HKZ";
            this.HKZ.Size = new System.Drawing.Size(75, 23);
            this.HKZ.TabIndex = 2;
            this.HKZ.Text = "HKZ";
            this.HKZ.UseVisualStyleBackColor = true;
            this.HKZ.Click += new System.EventHandler(this.HKZ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email_display);
            this.groupBox1.Controls.Add(this.prijmeni_display);
            this.groupBox1.Controls.Add(this.jmeno_display);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(487, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Item";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // email_display
            // 
            this.email_display.AutoSize = true;
            this.email_display.Location = new System.Drawing.Point(66, 62);
            this.email_display.Name = "email_display";
            this.email_display.Size = new System.Drawing.Size(0, 15);
            this.email_display.TabIndex = 6;
            // 
            // prijmeni_display
            // 
            this.prijmeni_display.AutoSize = true;
            this.prijmeni_display.Location = new System.Drawing.Point(66, 47);
            this.prijmeni_display.Name = "prijmeni_display";
            this.prijmeni_display.Size = new System.Drawing.Size(0, 15);
            this.prijmeni_display.TabIndex = 5;
            // 
            // jmeno_display
            // 
            this.jmeno_display.AutoSize = true;
            this.jmeno_display.Location = new System.Drawing.Point(66, 32);
            this.jmeno_display.Name = "jmeno_display";
            this.jmeno_display.Size = new System.Drawing.Size(0, 15);
            this.jmeno_display.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prijmeni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jmeno: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soucasny seznam";
            // 
            // button_zadat_cestu_k_souboru
            // 
            this.button_zadat_cestu_k_souboru.Location = new System.Drawing.Point(12, 48);
            this.button_zadat_cestu_k_souboru.Name = "button_zadat_cestu_k_souboru";
            this.button_zadat_cestu_k_souboru.Size = new System.Drawing.Size(109, 88);
            this.button_zadat_cestu_k_souboru.TabIndex = 5;
            this.button_zadat_cestu_k_souboru.Text = "Zadat cestu k souboru";
            this.button_zadat_cestu_k_souboru.UseVisualStyleBackColor = true;
            this.button_zadat_cestu_k_souboru.Click += new System.EventHandler(this.button_zadat_cestu_k_souboru_Click);
            // 
            // button_pridat_studenty_rucne
            // 
            this.button_pridat_studenty_rucne.Location = new System.Drawing.Point(13, 143);
            this.button_pridat_studenty_rucne.Name = "button_pridat_studenty_rucne";
            this.button_pridat_studenty_rucne.Size = new System.Drawing.Size(108, 88);
            this.button_pridat_studenty_rucne.TabIndex = 6;
            this.button_pridat_studenty_rucne.Text = "Pridat studenty rucne";
            this.button_pridat_studenty_rucne.UseVisualStyleBackColor = true;
            this.button_pridat_studenty_rucne.Click += new System.EventHandler(this.button_pridat_studenty_rucne_Click);
            // 
            // button_ulozit_zmeny
            // 
            this.button_ulozit_zmeny.Location = new System.Drawing.Point(487, 308);
            this.button_ulozit_zmeny.Name = "button_ulozit_zmeny";
            this.button_ulozit_zmeny.Size = new System.Drawing.Size(188, 74);
            this.button_ulozit_zmeny.TabIndex = 7;
            this.button_ulozit_zmeny.Text = "Ulozit zmeny";
            this.button_ulozit_zmeny.UseVisualStyleBackColor = true;
            this.button_ulozit_zmeny.Click += new System.EventHandler(this.button_ulozit_zmeny_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ulozit_zmeny);
            this.Controls.Add(this.button_pridat_studenty_rucne);
            this.Controls.Add(this.button_zadat_cestu_k_souboru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HKZ);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button HKZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label email_display;
        private System.Windows.Forms.Label prijmeni_display;
        private System.Windows.Forms.Label jmeno_display;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_zadat_cestu_k_souboru;
        private System.Windows.Forms.Button button_pridat_studenty_rucne;
        private System.Windows.Forms.Button button_ulozit_zmeny;
    }
}

