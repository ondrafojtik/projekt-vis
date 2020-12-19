namespace VIS
{
    partial class FormZadatCestuKSouboru
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_path = new System.Windows.Forms.TextBox();
            this.button_potvrdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // textbox_path
            // 
            this.textbox_path.Location = new System.Drawing.Point(67, 52);
            this.textbox_path.Name = "textbox_path";
            this.textbox_path.Size = new System.Drawing.Size(422, 23);
            this.textbox_path.TabIndex = 1;
            this.textbox_path.TextChanged += new System.EventHandler(this.textbox_path_TextChanged);
            // 
            // button_potvrdit
            // 
            this.button_potvrdit.Location = new System.Drawing.Point(67, 81);
            this.button_potvrdit.Name = "button_potvrdit";
            this.button_potvrdit.Size = new System.Drawing.Size(75, 23);
            this.button_potvrdit.TabIndex = 2;
            this.button_potvrdit.Text = "Potvrdit";
            this.button_potvrdit.UseVisualStyleBackColor = true;
            this.button_potvrdit.Click += new System.EventHandler(this.button_potvrdit_Click);
            // 
            // FormZadatCestuKSouboru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 127);
            this.Controls.Add(this.button_potvrdit);
            this.Controls.Add(this.textbox_path);
            this.Controls.Add(this.label1);
            this.Name = "FormZadatCestuKSouboru";
            this.Text = "FormZadatCestuKSouboru";
            this.Load += new System.EventHandler(this.FormZadatCestuKSouboru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_path;
        private System.Windows.Forms.Button button_potvrdit;
    }
}