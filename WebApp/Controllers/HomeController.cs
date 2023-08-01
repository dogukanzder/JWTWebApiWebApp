using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login() // ~/Home/Login
        {
            return View();
        }

        public ActionResult Users() // ~/Home/Users
        {
            return View();
        }

    }
}