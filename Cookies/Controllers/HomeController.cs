using Cookies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["Name"];
            if (cookie != null)
            {
                string name = Request.Cookies["Name"].Value;
                ViewData["Name"] = name;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(Visitor visitor)
        {
            if (ModelState.IsValid == true)
            {
                HttpCookie cookie = new HttpCookie("Name");
                cookie.Value = visitor.Name;

                HttpContext.Response.Cookies.Add(cookie);
                cookie.Expires = DateTime.Now.AddDays(1);
            }
            return RedirectToAction("Index");
        }
    }
}