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
    public partial class FormZadatStudentyRucne : Form
    {
        Form1 form;

        List<Student> students = new List<Student>();

        public FormZadatStudentyRucne(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button_pridat_studenta_Click(object sender, EventArgs e)
        {
            //button_pridat_studenta
            Student s = new Student(textbot_jmeno.Text, textbot_prijmeni.Text, textbot_email.Text, 
                        textbot_email_rodice.Text, textbot_telefon.Text, Trida.FindByID(Convert.ToInt32(textbot_id_tridy.Text)));
            students.Add(s);

            // clear textBoxes
            textbot_jmeno.Text = "";
            textbot_prijmeni.Text = "";
            textbot_email.Text = "";
            textbot_email_rodice.Text = "";
            textbot_telefon.Text = "";
            textbot_id_tridy.Text = "";

        }

        private void button_pokracovat_Click(object sender, EventArgs e)
        {
            //button_pokracovat
            form.AddStudentsManually(students);
            this.Hide();
        }
    }
}
