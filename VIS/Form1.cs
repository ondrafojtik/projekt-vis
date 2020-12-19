using System;
using DomainLayer.ActiveRecord;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace VIS
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>();
        List<Zamestnanec> teachers = new List<Zamestnanec>();
        List<Trida> classes = new List<Trida>();

        Menu form;

        public void AddStudentsFromPath(string path)
        {
            listBox1.Items.Clear();

            // deserialize
            if (!File.Exists(path))
            {
                Console.WriteLine("File doesnt exist!");
                return;
            }
            string content = File.ReadAllText(path);
            
            students.Clear();
            students = JsonSerializer.Deserialize<List<Student>>(content);
            foreach (Student s in students)
                listBox1.Items.Add(s);

        }

        public void AddStudentsManually(List<Student> buffer)
        {
            students.Clear();
            listBox1.Items.Clear();

            foreach (Student s in buffer)
            {
                students.Add(s);
                listBox1.Items.Add(s);
            }
            
        }

        public Form1(Menu form)
        {
            InitializeComponent();
            this.form = form;
            // init
            teachers = Zamestnanec.Find();
            classes = Trida.Find();
            students = Student.Find();

            foreach (Student st in students)
                listBox1.Items.Add(st);

            //foreach (Zamestnanec z in teachers)
            //    listBox1.Items.Add(z.jmeno);

            //foreach (Trida t in classes)
            //    listBox1.Items.Add(t.jmeno_tridy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // insert example

            //Student st = new Student("Evzen", "Jahudkovy", "borec007cz@seznam.cz", "evzenius40@gmail.com", "666777888", 1);
            //st.Insert();
            //listBox1.Items.Add(Student.FindByID(5).jmeno);

            //update example

            //Student s = Student.FindByID(3);
            //s.prijmeni = "Diretidovy";
            //s.Update();
            //
            //listBox1.Items.Clear();
            //students.Clear();
            //students = Student.Find();
            //
            //foreach (Student st in students)
            //    listBox1.Items.Add(st.prijmeni);

            //listBox1.Items.Clear();
            //listBox1.Items.Add(students[0].trida.ucitel.prijmeni);

            //string content = JsonSerializer.Serialize(students);
            //File.WriteAllText("C:\\dev\\VIS\\data.json", content);
            
            //listBox1.Items.Clear();
            //foreach (Znamka z in Znamka.Find())
            //{
            //    listBox1.Items.Add(z);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jmeno_display.Text = ((Student)listBox1.SelectedItem).jmeno;
            prijmeni_display.Text = ((Student)listBox1.SelectedItem).prijmeni;
            email_display.Text = ((Student)listBox1.SelectedItem).email;
        }

        private void HKZ_Click(object sender, EventArgs e)
        {
            string message = "Zitra volno!";

            foreach (Student s in students)
                s.SendEmail(message);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_zadat_cestu_k_souboru_Click(object sender, EventArgs e)
        {
            //button_zadat_cestu_k_souboru
            FormZadatCestuKSouboru form = new FormZadatCestuKSouboru(this);
            form.Show();
        }

        private void button_pridat_studenty_rucne_Click(object sender, EventArgs e)
        {
            //button_pridat_studenty_rucne
            FormZadatStudentyRucne form = new FormZadatStudentyRucne(this);
            form.Show();
        }

        private void button_ulozit_zmeny_Click(object sender, EventArgs e)
        {
            //button_ulozit_zmeny

            // writes everything into DB 
            //foreach (Student s in students)
            //    s.Insert();
            Hide();
            form.Show();
        }
    }
}
