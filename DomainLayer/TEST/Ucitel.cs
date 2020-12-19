using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.TEST
{

    // ACTIVE RECORD
    public class Ucitel : Person
    {

        public override int id { get; set; }
        public override string Jmeno { get; set; }
        public override string Prijmeni { get; set; }
        public override string Email { get; set; }

        string Telefon { get; set; }
        bool Reditel { get; set; }

        bool validateEmail(string email)
        {
            return true;
        }

        void sendEmail(string email)
        {
            //actually send email
            Console.WriteLine("Sending email to:" + email);
        }

        bool zaslat_hromadny_email(Trida trida)
        {
            List<string> _emails = trida.GetStudentEmails();
            foreach (string email in _emails)
                if (validateEmail(email))
                    sendEmail(email);
                else
                {
                    Console.WriteLine("Couldnt find email: " + email);
                    return false;
                }

            return true;
        }

    }
}
