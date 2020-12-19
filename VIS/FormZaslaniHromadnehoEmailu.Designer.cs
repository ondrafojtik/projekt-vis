namespace VIS
{
    partial class FormZaslaniHromadnehoEmailu
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
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.button_odeslat_zpravu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucitel_select = new System.Windows.Forms.Label();
            this.jmeno_tridy_select = new System.Windows.Forms.Label();
            this.label_ucitel = new System.Windows.Forms.Label();
            this.label_jmeno_tridy = new System.Windows.Forms.Label();
            this.combobox_seznam_trid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(383, 116);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(354, 299);
            this.textBox_text.TabIndex = 0;
            // 
            // button_odeslat_zpravu
            // 
            this.button_odeslat_zpravu.Location = new System.Drawing.Point(48, 325);
            this.button_odeslat_zpravu.Name = "button_odeslat_zpravu";
            this.button_odeslat_zpravu.Size = new System.Drawing.Size(166, 67);
            this.button_odeslat_zpravu.TabIndex = 2;
            this.button_odeslat_zpravu.Text = "Odelat zpravu";
            this.button_odeslat_zpravu.UseVisualStyleBackColor = true;
            this.button_odeslat_zpravu.Click += new System.EventHandler(this.button_odeslat_zpravu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucitel_select);
            this.groupBox2.Controls.Add(this.jmeno_tridy_select);
            this.groupBox2.Controls.Add(this.label_ucitel);
            this.groupBox2.Controls.Add(this.label_jmeno_tridy);
            this.groupBox2.Location = new System.Drawing.Point(48, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // ucitel_select
            // 
            this.ucitel_select.AutoSize = true;
            this.ucitel_select.Location = new System.Drawing.Point(83, 42);
            this.ucitel_select.Name = "ucitel_select";
            this.ucitel_select.Size = new System.Drawing.Size(0, 15);
            this.ucitel_select.TabIndex = 3;
            // 
            // jmeno_tridy_select
            // 
            this.jmeno_tridy_select.AutoSize = true;
            this.jmeno_tridy_select.Location = new System.Drawing.Point(83, 23);
            this.jmeno_tridy_select.Name = "jmeno_tridy_select";
            this.jmeno_tridy_select.Size = new System.Drawing.Size(0, 15);
            this.jmeno_tridy_select.TabIndex = 2;
            // 
            // label_ucitel
            // 
            this.label_ucitel.AutoSize = true;
            this.label_ucitel.Location = new System.Drawing.Point(7, 42);
            this.label_ucitel.Name = "label_ucitel";
            this.label_ucitel.Size = new System.Drawing.Size(37, 15);
            this.label_ucitel.TabIndex = 1;
            this.label_ucitel.Text = "Ucitel";
            // 
            // label_jmeno_tridy
            // 
            this.label_jmeno_tridy.AutoSize = true;
            this.label_jmeno_tridy.Location = new System.Drawing.Point(7, 23);
            this.label_jmeno_tridy.Name = "label_jmeno_tridy";
            this.label_jmeno_tridy.Size = new System.Drawing.Size(69, 15);
            this.label_jmeno_tridy.TabIndex = 0;
            this.label_jmeno_tridy.Text = "Jmeno tridy";
            // 
            // combobox_seznam_trid
            // 
            this.combobox_seznam_trid.FormattingEnabled = true;
            this.combobox_seznam_trid.Location = new System.Drawing.Point(55, 49);
            this.combobox_seznam_trid.Name = "combobox_seznam_trid";
            this.combobox_seznam_trid.Size = new System.Drawing.Size(121, 23);
            this.combobox_seznam_trid.TabIndex = 4;
            this.combobox_seznam_trid.SelectedIndexChanged += new System.EventHandler(this.combobox_seznam_trid_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seznam trid";
            // 
            // FormZaslaniHromadnehoEmailu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_seznam_trid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_odeslat_zpravu);
            this.Controls.Add(this.textBox_text);
            this.Name = "FormZaslaniHromadnehoEmailu";
            this.Text = "FormZaslaniHromadnehoEmailu";
            this.Load += new System.EventHandler(this.FormZaslaniHromadnehoEmailu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Button button_odeslat_zpravu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ucitel_select;
        private System.Windows.Forms.Label jmeno_tridy_select;
        private System.Windows.Forms.Label label_ucitel;
        private System.Windows.Forms.Label label_jmeno_tridy;
        private System.Windows.Forms.ComboBox combobox_seznam_trid;
        private System.Windows.Forms.Label label1;
    }
}