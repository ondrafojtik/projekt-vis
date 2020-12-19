using DataLayer.TableDataGateway;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DomainLayer.ActiveRecord
{
    public class Student
    {

        //the data setup
        public int id { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public string email { get; set; }
        public string email_rodice { get; set; }
        public string telefon_rodice { get; set; }
        public Trida trida { get; set; }

        public static Student MapResultsetToObject(DataRow dr)
        {
            int _id = Convert.ToInt32(dr.ItemArray[0].ToString());
            string _jmeno = dr.ItemArray[1].ToString();
            string _prijmeni = dr.ItemArray[2].ToString();
            string _email = dr.ItemArray[3].ToString();
            string _email_rodice = dr.ItemArray[4].ToString();
            string _telefon_rodice = dr.ItemArray[5].ToString();
            int _trida_id = Convert.ToInt32(dr.ItemArray[6].ToString());

            TridaGateway trida_gtw = new TridaGateway();
            Trida _trida = Trida.MapResultsetToObject(trida_gtw.FindByID(_trida_id).Rows[0]);

            Student st = new Student(_id, _jmeno, _prijmeni, _email, _email_rodice, _telefon_rodice, _trida);

            return st;
        }

        public Student() { trida = new Trida(); }

        public Student(string jmeno, string prijmeni, string email, string email_rodice, string telefon_rodice, Trida trida)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.email = email;
            this.email_rodice = email_rodice;
            this.telefon_rodice = telefon_rodice;

            this.trida = trida;
        }

        public Student(int id, string jmeno, string prijmeni, string email, string email_rodice, string telefon_rodice, Trida trida)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.email = email;
            this.email_rodice = email_rodice;
            this.telefon_rodice = telefon_rodice;

            this.trida = trida;
        }

        // find all the students
        public static List<Student> Find()
        {
            List<Student> studentList = new List<Student>();

            StudentGateway student_gtw = new StudentGateway();
            DataTable dt = student_gtw.Find();
            foreach (DataRow dr in dt.Rows)
                studentList.Add(MapResultsetToObject(dr));

            return studentList;
        }
        
        //logic
        public static Student FindByID(int id)
        {
            StudentGateway student_gtw = new StudentGateway();
            DataTable dt = student_gtw.FindByID(id);
            if (dt.Rows.Count == 0)
                return new Student(-1, "ERROR", "ERROR", "ERROR", "ERROR", "ERROR", new Trida());
            DataRow dr = dt.Rows[0];

            return MapResultsetToObject(dr);
        }

        public void Insert()
        {
            StudentGateway student_gtw = new StudentGateway();
            id = student_gtw.Insert(jmeno, prijmeni, email, email_rodice, telefon_rodice, trida.id);

        }

        public void Update()
        {
            StudentGateway student_gtw = new StudentGateway();
            student_gtw.Update(id, jmeno, prijmeni, email, email_rodice, telefon_rodice, trida.id);
        }

        public void SendEmail(string message)
        {
            Console.WriteLine("Sending email to: " + jmeno + " with message: " + message);
        }

        public override string ToString()
        {
            return prijmeni;
        }

    }
}
