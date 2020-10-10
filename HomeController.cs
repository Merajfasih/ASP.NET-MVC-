using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLhelper.Models;

namespace HTMLhelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employe emp = new Employe()
            {
                address = "This is my adress",
                name = "Meraj",
                IsEmoloye = true
            };
            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Employe emp)
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Studentview()
        {
            Student std = new Student()
            {
                ID = 1,
                Name = "Meraj",
                Dateofbirth = DateTime.Now,
                Email = "merajfasih910@gmail.com",
                IsOnline = true
            };
            return View(std);
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}