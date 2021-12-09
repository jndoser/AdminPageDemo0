using AdminPageDemo0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPageDemo0.Controllers
{
    public class HomeController : Controller
    {
        AirDB db = new AirDB();
        public ActionResult Index()
        {
            return View(db.ChuyenBays.ToList());
        }
    }
}