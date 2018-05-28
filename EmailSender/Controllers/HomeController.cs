using EmailSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace EmailSender.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterationPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterationPage(Registeration reg)
        {
            if (ModelState.IsValid)
            {
                WebMail.Send("yourEmail", reg.Name + "is coming to interview", reg.Message + "<br/><br/> My Number: " + reg.Mobile + "<br/><br/>My Email: " + reg.Email, null, null, null, true, null, null, null, null, null, reg.Email);
            }
            return RedirectToAction("ThankYou");
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}