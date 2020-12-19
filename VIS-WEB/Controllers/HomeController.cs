using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VIS_WEB.Models;
using DomainLayer.ActiveRecord;
using System.Text;
using System.Net;
using System.IO;

namespace VIS_WEB.Controllers
{
    public class HomeController : Controller
    {

        
        private int STUDENT_LOGGED_IN_ID = 1;

        private readonly ILogger<HomeController> _logger;
        
        private bool isViable(List<Studuje> studuje, int id)
        {
            int viable = 0;
            foreach (Studuje s in studuje)
                if (s.id == id)
                    viable += 1;

            if (viable > 0)
                return true;

            return false;
        }

        private bool containsPredmetID(List<Studuje> studuje, int id)
        {
            int viable = 0;
            foreach (Studuje s in studuje)
                if (s.predmet.id == id)
                    viable += 1;

            if (viable > 0)
                return true;

            return false;
        }

        // je v maturitnim rocniku
        private bool maturitaValidation(MaturitaForm form)
        {
            return true;
        }

        // odeslani formulare na registraci.. 
        private void RegisterToMaturita()
        {
            ;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Predmet> subjects = new List<Predmet>();
            List<Studuje> studuje = new List<Studuje>();

            foreach (Studuje st in Studuje.Find())
                if (st.student.id == STUDENT_LOGGED_IN_ID)
                    studuje.Add(st);

            foreach (Predmet p in Predmet.Find())
                if (containsPredmetID(studuje, p.id))
                    subjects.Add(p);

            ViewBag.subjects = subjects;
            return View();
        }

        public IActionResult Detail(int id)
        {
            List<Studuje> studuje = new List<Studuje>();
            List<Znamka> marks = new List<Znamka>();
            List<Predmet> subjects = new List<Predmet>();

            foreach (Studuje st in Studuje.Find())
                if ((st.student.id == STUDENT_LOGGED_IN_ID) && st.predmet.id == id)
                    studuje.Add(st);

            foreach (Znamka z in Znamka.Find())
                if (isViable(studuje, z.studuje.id))
                    marks.Add(z);

            foreach (Studuje st in Studuje.Find())
                if (st.student.id == STUDENT_LOGGED_IN_ID)
                    studuje.Add(st);

            foreach (Predmet p in Predmet.Find())
                if (containsPredmetID(studuje, p.id))
                    subjects.Add(p);

            ViewBag.subjects = subjects;

            ViewBag.marks = marks;
            ViewBag.subjects = subjects;
            ViewBag.predmet = Predmet.FindByID(id);

            return View();
        }

        [HttpPost]
        public IActionResult SendMarks(int id)
        {
            StringBuilder sb = new StringBuilder();
            Student s = Student.FindByID(STUDENT_LOGGED_IN_ID);
            sb.Append("Znamky z " + Predmet.FindByID(id).jmeno + ": ");
            float sum = 0;
            float count = 0;
            List<Studuje> studuje = new List<Studuje>();
            foreach (Studuje st in Studuje.Find())
                if ((st.student.id == s.id) && (st.predmet.id == id))
                    studuje.Add(st);

            foreach (Znamka z in Znamka.Find())
                if (isViable(studuje, z.studuje.id))
                {
                    sb.Append(z.znamka + ", ");
                    sum += z.znamka;
                    count += 1;
                }
            sb.Remove(sb.Length - 2, 2);

            float final = sum / count;
            sb.Append(" s prumerem: " + final);

            Debug.WriteLine(sb.ToString());
            s.SendEmail(sb.ToString());

            using (StreamWriter sw = new StreamWriter("C:\\dev\\VIS\\znamky.txt"))
            {
                sw.Write(sb.ToString());
            }
            
            
            return RedirectToAction("Detail", "Home", new { id = id });
        }

        public IActionResult Register()
        {
            List<Predmet> subjects = new List<Predmet>();
            List<Studuje> studuje = new List<Studuje>();

            foreach (Studuje st in Studuje.Find())
                if (st.student.id == STUDENT_LOGGED_IN_ID)
                    studuje.Add(st);

            foreach (Predmet p in Predmet.Find())
                if (containsPredmetID(studuje, p.id))
                    subjects.Add(p);

            ViewBag.subjects = subjects;
            return View();
        }

        [HttpPost]
        public IActionResult Register(MaturitaForm form)
        {
            List<Predmet> subjects = new List<Predmet>();
            List<Studuje> studuje = new List<Studuje>();

            foreach (Studuje st in Studuje.Find())
                if (st.student.id == STUDENT_LOGGED_IN_ID)
                    studuje.Add(st);

            foreach (Predmet p in Predmet.Find())
                if (containsPredmetID(studuje, p.id))
                    subjects.Add(p);

            ViewBag.subjects = subjects;

            if (form.jmeno != null && form.prijmeni != null)
            {     
                if (maturitaValidation(form))
                {
                    RegisterToMaturita();
                    Debug.WriteLine("Registered!");
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Register", "Home");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
