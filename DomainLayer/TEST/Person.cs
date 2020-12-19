using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.TEST
{
    public abstract class Person
    {
        public abstract int id { get; set; }
        public abstract string Jmeno { get; set; }
        public abstract string Prijmeni { get; set; }
        public abstract string Email { get; set; }
    }
}
