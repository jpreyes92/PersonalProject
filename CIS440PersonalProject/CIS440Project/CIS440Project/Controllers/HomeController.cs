using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS440Project.Models;

namespace CIS440Project.Controllers
{
    public class HomeController : Controller
    {
        private Project2DBContext db = new Project2DBContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.Projects.ToList());
        }

    }
}
