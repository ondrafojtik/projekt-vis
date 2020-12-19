using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLayer.TableDataGateway;

namespace DomainLayer.ActiveRecord
{
    public class Znamka
    {
        //the data setup
        public int id { get; set; }
        public int znamka { get; set; }
        public string popis { get; set; }
        public Studuje studuje { get; set; }

        public static Znamka MapResultsetToObject(DataRow dr)
        {
            int _id = Convert.ToInt32(dr.ItemArray[0].ToString());
            int _znamka = Convert.ToInt32(dr.ItemArray[1].ToString());
            string _popis = dr.ItemArray[2].ToString();
            int _studuje_id = Convert.ToInt32(dr.ItemArray[3].ToString());

            StudujeGateway studuje_gtw = new StudujeGateway();
            Studuje _studuje= Studuje.MapResultsetToObject(studuje_gtw.FindByID(_studuje_id).Rows[0]);

            Znamka z = new Znamka(_id, _znamka, _popis, _studuje);

            return z;
        }

        public Znamka() { ; }

        public Znamka(int znamka, string popis, Studuje studuje)
        {
            this.znamka = znamka;
            this.popis = popis;
            this.studuje = studuje;
        }

        public Znamka(int id, int znamka, string popis, Studuje studuje)
        {
            this.id = id;
            this.znamka = znamka;
            this.popis = popis;
            this.studuje = studuje;
        }

        // find all the students
        public static List<Znamka> Find()
        {
            List<Znamka> znamkaList = new List<Znamka>();

            ZnamkaGateway znamka_gtw = new ZnamkaGateway();
            DataTable dt = znamka_gtw.Find();
            foreach (DataRow dr in dt.Rows)
                znamkaList.Add(MapResultsetToObject(dr));

            return znamkaList;
        }

        //logic
        public static Znamka FindByID(int id)
        {
            ZnamkaGateway znamka_gtw = new ZnamkaGateway();
            DataTable dt = znamka_gtw.FindByID(id);
            DataRow dr = dt.Rows[0];

            return MapResultsetToObject(dr);
        }

        public void Insert()
        {
            ZnamkaGateway znamka_gtw = new ZnamkaGateway();
            id = znamka_gtw.Insert(znamka, popis, studuje.id);

        }

        public void Update()
        {
            ZnamkaGateway znamka_gtw = new ZnamkaGateway();
            znamka_gtw.Update(id, znamka, popis, studuje.id);
        }

        public override string ToString()
        {
            return id.ToString();
        }

    }
}
