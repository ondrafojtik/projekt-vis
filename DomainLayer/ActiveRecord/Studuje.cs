using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLayer.TableDataGateway;

namespace DomainLayer.ActiveRecord
{
    public class Studuje
    {
        //the data setup
        public int id { get; set; }
        public Student student { get; set; }
        public Predmet predmet { get; set; }

        public static Studuje MapResultsetToObject(DataRow dr)
        {
            int _id = Convert.ToInt32(dr.ItemArray[0].ToString());
            int _student_id = Convert.ToInt32(dr.ItemArray[1].ToString());
            int _predmet_id = Convert.ToInt32(dr.ItemArray[2].ToString());

            StudentGateway student_gtw = new StudentGateway();
            Student _student = Student.MapResultsetToObject(student_gtw.FindByID(_student_id).Rows[0]);

            PredmetGateway predmet_gtw = new PredmetGateway();
            Predmet _predmet = Predmet.MapResultsetToObject(predmet_gtw.FindByID(_predmet_id).Rows[0]);

            Studuje st = new Studuje(_id, _student, _predmet);

            return st;
        }

        public Studuje() { ; }

        public Studuje(Student student, Predmet predmet)
        {
            this.student = student;
            this.predmet = predmet;
        }

        public Studuje(int id, Student student, Predmet predmet)
        {
            this.id = id;
            this.student = student;
            this.predmet = predmet;
        }

        // find all the students
        public static List<Studuje> Find()
        {
            List<Studuje> studujeList = new List<Studuje>();

            StudujeGateway studuje_gtw = new StudujeGateway();
            DataTable dt = studuje_gtw.Find();
            foreach (DataRow dr in dt.Rows)
                studujeList.Add(MapResultsetToObject(dr));

            return studujeList;
        }

        //logic
        public static Studuje FindByID(int id)
        {
            StudujeGateway studuje_gtw = new StudujeGateway();
            DataTable dt = studuje_gtw.FindByID(id);
            DataRow dr = dt.Rows[0];

            return MapResultsetToObject(dr);
        }

        public void Insert()
        {
            StudujeGateway studuje_gtw = new StudujeGateway();
            id = studuje_gtw.Insert(student.id, predmet.id);

        }

        public void Update()
        {
            StudujeGateway studuje_gtw = new StudujeGateway();
            studuje_gtw.Update(id, student.id, predmet.id);
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
