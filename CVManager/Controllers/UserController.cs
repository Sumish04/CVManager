using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVManager.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index(int? userID)
        {
            ViewBag.UserID = userID;
            return View();
        }
    }
}