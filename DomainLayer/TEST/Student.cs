using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DomainLayer.TEST
{
    // ACTIVE RECORD
    public class Student : Person
    {
        
        public override int id { get; set; }
        public override string Jmeno { get; set; }
        public override string Prijmeni { get; set; }
        public override string Email { get; set; }

        string Email_rodice { get; set; }
        string Telefon_rodice { get; set; }


    }
}
