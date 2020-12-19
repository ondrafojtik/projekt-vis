using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DomainLayer.ActiveRecord;

namespace VIS
{
    public partial class FormZaslaniHromadnehoEmailu : Form
    {
        Menu form;

        public FormZaslaniHromadnehoEmailu(Menu form)
        {
            InitializeComponent();
            this.form = form;
        }
    
        private void FormZaslaniHromadnehoEmailu_Load(object sender, EventArgs e)
        {
            //combobox_seznam_trid
            foreach (Trida t in Trida.Find())
                combobox_seznam_trid.Items.Add(t);
        }

        private void button_odeslat_zpravu_Click(object sender, EventArgs e)
        {
            if (combobox_seznam_trid.SelectedItem == null)
            {
                MessageBox.Show("Vyber tridu");
                return;
            }

            // button_odeslat_zpravu
            foreach (Student s in Student.Find())
                if (s.trida.id == ((Trida)combobox_seznam_trid.SelectedItem).id)
                    Console.WriteLine("Sending message to: " + s.prijmeni + " with message: " + textBox_text.Text);
            
            Hide();
            form.Show();
        }

        private void combobox_seznam_trid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trida t = (Trida)combobox_seznam_trid.SelectedItem;

            jmeno_tridy_select.Text = t.jmeno_tridy;
            ucitel_select.Text = t.ucitel.prijmeni;
        }
    }
}
