using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLayer.TableDataGateway;

namespace DomainLayer.ActiveRecord
{
    public class Zamestnanec
    {
        //the data setup
        public int id { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public bool reditel { get; set; }

        public static Zamestnanec MapResultsetToObject(DataRow dr)
        {
            int _id = Convert.ToInt32(dr.ItemArray[0].ToString());
            string _jmeno = dr.ItemArray[1].ToString();
            string _prijmeni = dr.ItemArray[2].ToString();
            string _email = dr.ItemArray[3].ToString();
            string _telefon = dr.ItemArray[4].ToString();
            bool _reditel = Convert.ToBoolean(dr.ItemArray[5].ToString());

            Zamestnanec z = new Zamestnanec(_id, _jmeno, _prijmeni, _email, _telefon, _reditel);

            return z;
        }

        public Zamestnanec() {; }

        public Zamestnanec(string jmeno, string prijmeni, string email, string telefon, bool reditel)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.email = email;
            this.telefon = telefon;
            this.reditel = reditel;
        }

        public Zamestnanec(int id, string jmeno, string prijmeni, string email, string telefon, bool reditel)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.email = email;
            this.telefon = telefon;
            this.reditel = reditel;
        }

        // find all the students
        public static List<Zamestnanec> Find()
        {
            List<Zamestnanec> zamestnanecList = new List<Zamestnanec>();

            ZamestnanecGateway zamestnanec_gtw = new ZamestnanecGateway();
            DataTable dt = zamestnanec_gtw.Find();
            foreach (DataRow dr in dt.Rows)
                zamestnanecList.Add(MapResultsetToObject(dr));

            return zamestnanecList;
        }

        //logic
        public static Zamestnanec FindByID(int id)
        {
            ZamestnanecGateway zamestnanec_gtw = new ZamestnanecGateway();
            DataTable dt = zamestnanec_gtw.FindByID(id);
            DataRow dr = dt.Rows[0];

            return MapResultsetToObject(dr);
        }

        public void Insert()
        {
            ZamestnanecGateway zamestnanec_gtw = new ZamestnanecGateway();
            id = zamestnanec_gtw.Insert(jmeno, prijmeni, email, telefon, reditel);
        }

        public void Update()
        {
            ZamestnanecGateway zamestnanec_gtw = new ZamestnanecGateway();
            zamestnanec_gtw.Update(id, jmeno, prijmeni, email, telefon, reditel);
        }

    }
}
