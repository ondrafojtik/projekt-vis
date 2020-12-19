using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VIS
{
    public partial class FormZadatCestuKSouboru : Form
    {
        private Form1 form;

        public FormZadatCestuKSouboru(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }
    
        private void FormZadatCestuKSouboru_Load(object sender, EventArgs e)
        {
            
        }

        private void textbox_path_TextChanged(object sender, EventArgs e)
        {
            //textbox_path

        }

        private void button_potvrdit_Click(object sender, EventArgs e)
        {
            //button_potvrdit

            string path = textbox_path.Text;
            if (File.Exists(path))
            { 
                form.AddStudentsFromPath(path);
                Hide();
            }
            else
            {
                MessageBox.Show("Cesta k souboru nebyla nalezena");
            }
        }
    }
}
