using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.TEST
{

    public class Trida
    {

        int id { get; set; }
        string Jmeno_tridy { get; set; }

        public List<string> GetStudentEmails()
        {
            List<string> _emails = new List<string>();
            //call to the db
            _emails.Add("ondra@seznam.cz");
            return _emails;
        }
    }
}
