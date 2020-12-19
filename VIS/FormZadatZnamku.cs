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
    public partial class FormZadatZnamku : Form
    {

        Menu form;

        // get only subjects, that the student actually studies
        private void GetActualSubjects()
        {
            combobox_predmet.Items.Clear();
            foreach (Studuje st in Studuje.Find())
                if (st.student.id == ((Student)combobox_student.SelectedItem).id)
                    combobox_predmet.Items.Add(st.predmet);
        }

        public FormZadatZnamku(Menu form)
        {
            InitializeComponent();
            foreach (Student s in Student.Find())
                combobox_student.Items.Add(s);
            foreach (Predmet p in Predmet.Find())
                combobox_predmet.Items.Add(p);

            this.form = form;
        }
    
        private void FormZadatZnamku_Load(object sender, EventArgs e)
        {
            //selected_student_jmeno, selected_predmet_jmeno
        }

        private void button_ulozit_Click(object sender, EventArgs e)
        {
            // save to the DB
            Hide();
            form.Show();
        }

        private void textbox_id_studenta_TextChanged(object sender, EventArgs e)
        {
            Student s = Student.FindByID(Convert.ToInt32(textbox_id_studenta.Text));
            combobox_student.SelectedItem = s;
            combobox_student.Text = s.ToString();

            selected_student_jmeno.Text = s.jmeno;
            selected_student_prijmeni.Text = s.prijmeni;
            selected_student_email.Text = s.email;

            GetActualSubjects();
        }

        private void combobox_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox_id_studenta.Text = ((Student)combobox_student.SelectedItem).id.ToString();
            combobox_predmet.Text = "";
            GetActualSubjects();
        }

        private void textbox_id_predmetu_TextChanged(object sender, EventArgs e)
        {
            Predmet p = Predmet.FindByID(Convert.ToInt32(textbox_id_predmetu.Text));
            combobox_predmet.SelectedItem = p;
            combobox_predmet.Text = p.ToString();

            selected_predmet_jmeno.Text = p.jmeno;
        }

        private void combobox_predmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox_id_predmetu.Text = ((Predmet)combobox_predmet.SelectedItem).id.ToString();
        }
    }
}
