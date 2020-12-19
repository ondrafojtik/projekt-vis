namespace VIS
{
    partial class FormZadatZnamku
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
            this.textbox_id_predmetu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_student = new System.Windows.Forms.ComboBox();
            this.combobox_predmet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_znamka = new System.Windows.Forms.TextBox();
            this.textbox_popis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selected_student_email = new System.Windows.Forms.Label();
            this.selected_student_prijmeni = new System.Windows.Forms.Label();
            this.selected_student_jmeno = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selected_predmet_jmeno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_ulozit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_id_studenta
            // 
            this.textbox_id_studenta.Location = new System.Drawing.Point(100, 17);
            this.textbox_id_studenta.Name = "textbox_id_studenta";
            this.textbox_id_studenta.Size = new System.Drawing.Size(100, 23);
            this.textbox_id_studenta.TabIndex = 0;
            this.textbox_id_studenta.TextChanged += new System.EventHandler(this.textbox_id_studenta_TextChanged);
            // 
            // textbox_id_predmetu
            // 
            this.textbox_id_predmetu.Location = new System.Drawing.Point(288, 17);
            this.textbox_id_predmetu.Name = "textbox_id_predmetu";
            this.textbox_id_predmetu.Size = new System.Drawing.Size(100, 23);
            this.textbox_id_predmetu.TabIndex = 1;
            this.textbox_id_predmetu.TextChanged += new System.EventHandler(this.textbox_id_predmetu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vybrat studenta\r\n   ze seznamu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vybrat predmet\r\n   ze seznamu";
            // 
            // combobox_student
            // 
            this.combobox_student.FormattingEnabled = true;
            this.combobox_student.Location = new System.Drawing.Point(24, 90);
            this.combobox_student.Name = "combobox_student";
            this.combobox_student.Size = new System.Drawing.Size(121, 23);
            this.combobox_student.TabIndex = 4;
            this.combobox_student.SelectedIndexChanged += new System.EventHandler(this.combobox_student_SelectedIndexChanged);
            // 
            // combobox_predmet
            // 
            this.combobox_predmet.FormattingEnabled = true;
            this.combobox_predmet.Location = new System.Drawing.Point(167, 89);
            this.combobox_predmet.Name = "combobox_predmet";
            this.combobox_predmet.Size = new System.Drawing.Size(121, 23);
            this.combobox_predmet.TabIndex = 5;
            this.combobox_predmet.SelectedIndexChanged += new System.EventHandler(this.combobox_predmet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID studenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID predmetu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Znamka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Popis:";
            // 
            // textbox_znamka
            // 
            this.textbox_znamka.Location = new System.Drawing.Point(84, 230);
            this.textbox_znamka.Name = "textbox_znamka";
            this.textbox_znamka.Size = new System.Drawing.Size(100, 23);
            this.textbox_znamka.TabIndex = 10;
            // 
            // textbox_popis
            // 
            this.textbox_popis.Location = new System.Drawing.Point(84, 249);
            this.textbox_popis.Name = "textbox_popis";
            this.textbox_popis.Size = new System.Drawing.Size(100, 23);
            this.textbox_popis.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selected_student_email);
            this.groupBox1.Controls.Add(this.selected_student_prijmeni);
            this.groupBox1.Controls.Add(this.selected_student_jmeno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(467, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // selected_student_email
            // 
            this.selected_student_email.AutoSize = true;
            this.selected_student_email.Location = new System.Drawing.Point(68, 61);
            this.selected_student_email.Name = "selected_student_email";
            this.selected_student_email.Size = new System.Drawing.Size(0, 15);
            this.selected_student_email.TabIndex = 5;
            // 
            // selected_student_prijmeni
            // 
            this.selected_student_prijmeni.AutoSize = true;
            this.selected_student_prijmeni.Location = new System.Drawing.Point(68, 42);
            this.selected_student_prijmeni.Name = "selected_student_prijmeni";
            this.selected_student_prijmeni.Size = new System.Drawing.Size(0, 15);
            this.selected_student_prijmeni.TabIndex = 4;
            // 
            // selected_student_jmeno
            // 
            this.selected_student_jmeno.AutoSize = true;
            this.selected_student_jmeno.Location = new System.Drawing.Point(68, 23);
            this.selected_student_jmeno.Name = "selected_student_jmeno";
            this.selected_student_jmeno.Size = new System.Drawing.Size(0, 15);
            this.selected_student_jmeno.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Prijmeni:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jmeno:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selected_predmet_jmeno);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(467, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 73);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predmet";
            // 
            // selected_predmet_jmeno
            // 
            this.selected_predmet_jmeno.AutoSize = true;
            this.selected_predmet_jmeno.Location = new System.Drawing.Point(58, 38);
            this.selected_predmet_jmeno.Name = "selected_predmet_jmeno";
            this.selected_predmet_jmeno.Size = new System.Drawing.Size(0, 15);
            this.selected_predmet_jmeno.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Jmeno:";
            // 
            // button_ulozit
            // 
            this.button_ulozit.Location = new System.Drawing.Point(467, 290);
            this.button_ulozit.Name = "button_ulozit";
            this.button_ulozit.Size = new System.Drawing.Size(144, 55);
            this.button_ulozit.TabIndex = 14;
            this.button_ulozit.Text = "Ulozit";
            this.button_ulozit.UseVisualStyleBackColor = true;
            this.button_ulozit.Click += new System.EventHandler(this.button_ulozit_Click);
            // 
            // FormZadatZnamku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ulozit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textbox_popis);
            this.Controls.Add(this.textbox_znamka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combobox_predmet);
            this.Controls.Add(this.combobox_student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_id_predmetu);
            this.Controls.Add(this.textbox_id_studenta);
            this.Name = "FormZadatZnamku";
            this.Text = "FormZadatZnamku";
            this.Load += new System.EventHandler(this.FormZadatZnamku_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textbox_id_studenta;
        private System.Windows.Forms.TextBox textbox_id_predmetu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_student;
        private System.Windows.Forms.ComboBox combobox_predmet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_znamka;
        private System.Windows.Forms.TextBox textbox_popis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label selected_student_email;
        private System.Windows.Forms.Label selected_student_prijmeni;
        private System.Windows.Forms.Label selected_student_jmeno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label selected_predmet_jmeno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_ulozit;
    }
}