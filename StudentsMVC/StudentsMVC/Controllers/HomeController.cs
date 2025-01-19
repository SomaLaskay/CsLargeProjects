using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page - Academy of Learning";

            return View();
        }

        public ActionResult Instructor(int id = 1)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Soma",
                    LastName = "Laskay"
                },

                new Instructor
                {
                    Id = 2,
                    FirstName = "Timea",
                    LastName = "Toth"
                },

                new Instructor
                {
                    Id = 3,
                    FirstName = "Pipe",
                    LastName = "Ferret"
                }
            };

            return View(instructors);
        }
    }
}