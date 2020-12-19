using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLayer.TableDataGateway;

namespace DomainLayer.ActiveRecord
{
    public class Predmet
    {
        public int id { get; set; }
        public string jmeno { get; set; }

        public static Predmet MapResultsetToObject(DataRow dr)
        {
            int _id = Convert.ToInt32(dr.ItemArray[0].ToString());
            string _jmeno = dr.ItemArray[1].ToString();

            PredmetGateway predmet_gtw = new PredmetGateway();

            Predmet p = new Predmet(_id, _jmeno);;
            return p;
        }

        public Predmet() { ; }

        public Predmet(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public Predmet(int id, string jmeno)
        {
            this.id = id;
            this.jmeno = jmeno;
        }

        // find all the students
        public static List<Predmet> Find()
        {
            List<Predmet> predmetList = new List<Predmet>();

            PredmetGateway predmet_gtw = new PredmetGateway();
            DataTable dt = predmet_gtw.Find();
            foreach (DataRow dr in dt.Rows)
                predmetList.Add(MapResultsetToObject(dr));

            return predmetList;
        }

        //logic
        public static Predmet FindByID(int id)
        {
            PredmetGateway predmet_gtw = new PredmetGateway();
            DataTable dt = predmet_gtw.FindByID(id);
            DataRow dr = dt.Rows[0];

            return MapResultsetToObject(dr);
        }

        public void Insert()
        {
            PredmetGateway predmet_gtw = new PredmetGateway();
            id = predmet_gtw.Insert(jmeno);
        }

        public void Update()
        {
            PredmetGateway predmet_gtw = new PredmetGateway();
            predmet_gtw.Update(id, jmeno);
        }

        public override string ToString()
        {
            return jmeno;
        }
    }
}
