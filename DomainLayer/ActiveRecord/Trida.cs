using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLayer.TableDataGateway;

namespace DomainLayer.ActiveRecord
{
    public class Trida
    {
        public int id { get; set; }
        public string jmeno_tridy { get; set; }
        public Zamestnanec ucitel { get; set; }

        public static Trida MapResultsetToObject(DataRow dr)
        {
            int _id = Convert.ToInt32(dr.ItemArray[0].ToString());
            string _jmeno_tridy = dr.ItemArray[1].ToString();
            int _ucitel_id = Convert.ToInt32(dr.ItemArray[2].ToString());

            ZamestnanecGateway zamestnanec_gtw = new ZamestnanecGateway();
            Zamestnanec _ucitel = Zamestnanec.MapResultsetToObject(zamestnanec_gtw.FindByID(_ucitel_id).Rows[0]); 
            
            
            Trida t = new Trida(_id, _jmeno_tridy, _ucitel);
            return t;
        }

        public Trida() {; }

        public Trida(string jmeno_tridy, Zamestnanec ucitel)
        {
            this.jmeno_tridy = jmeno_tridy;
            this.ucitel = ucitel;
        }

        public Trida(int id, string jmeno_tridy, Zamestnanec ucitel)
        {
            this.id = id;
            this.jmeno_tridy = jmeno_tridy;
            this.ucitel = ucitel;
        }

        // find all the students
        public static List<Trida> Find()
        {
            List<Trida> tridaList = new List<Trida>();

            TridaGateway trida_gtw = new TridaGateway();
            DataTable dt = trida_gtw.Find();
            foreach (DataRow dr in dt.Rows)
                tridaList.Add(MapResultsetToObject(dr));

            return tridaList;
        }

        //logic
        public static Trida FindByID(int id)
        {
            TridaGateway trida_gtw = new TridaGateway();
            DataTable dt = trida_gtw.FindByID(id);
            DataRow dr = dt.Rows[0];

            return MapResultsetToObject(dr);
        }

        public void Insert()
        {
            TridaGateway trida_gtw = new TridaGateway();
            id = trida_gtw.Insert(jmeno_tridy, ucitel.id);
        }

        public void Update()
        {
            TridaGateway trida_gtw = new TridaGateway();
            trida_gtw.Update(id, jmeno_tridy, ucitel.id);
        }

        public override string ToString()
        {
            return jmeno_tridy;
        }
    }
}
