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
    public partial class FormKontaktovaniStudenta : Form
    {
        Menu form;

        public FormKontaktovaniStudenta(Menu form)
        {
            InitializeComponent();
            this.form = form;

            foreach (Student s in Student.Find()) 
                combobox_seznam.Items.Add(s);
        }
    
        private void FormZadatZnamku_Load(object sender, EventArgs e)
        {
    
        }

        private void button_kontaktovat_rodice_Click(object sender, EventArgs e)
        {
            if (textbox_id_studenta.Text != null && textbox_id_studenta.Text != "")
                MessageBox.Show("Telefon: " + Student.FindByID(Convert.ToInt32((textbox_id_studenta.Text))).telefon_rodice);
        }

        private void button_odeslat_Click(object sender, EventArgs e)
        {
            if (textbox_id_studenta.Text == "")
            {
                MessageBox.Show("Vyberte studenta..");
                return;
            }

            // button_odeslat
            Student s = Student.FindByID(Convert.ToInt32(textbox_id_studenta.Text));
            if (s.id != -1)
            {
                s.SendEmail(textbox_obsah_zpravy.Text);
                Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Incorrect student ID");
            }
            
        }

        private void combobox_seznam_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox_id_studenta.Text = ((Student)combobox_seznam.SelectedItem).id.ToString();
            
        }

        private void textbox_id_studenta_TextChanged(object sender, EventArgs e)
        {
            Student s = Student.FindByID(Convert.ToInt32(textbox_id_studenta.Text));
            combobox_seznam.SelectedItem = s;
            combobox_seznam.Text = s.ToString();

            selected_jmeno.Text = s.jmeno;
            selected_prijmeni.Text = s.prijmeni;
            selected_email.Text = s.email;

        }
    }
}
