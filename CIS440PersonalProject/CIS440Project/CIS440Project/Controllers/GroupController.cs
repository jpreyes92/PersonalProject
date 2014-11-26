using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIS440Project.Models;

namespace CIS440Project.Controllers
{ 
    public class GroupController : Controller
    {
        private GroupDBContext db = new GroupDBContext();

        //
        // GET: /Group/

        public ViewResult Index()
        {
            return View(db.Groups.ToList());
        }

        //
        // GET: /Group/Details/5

        public ViewResult Details(int id)
        {
            GroupDB groupdb = db.Groups.Find(id);
            return View(groupdb);
        }

        //
        // GET: /Group/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Group/Create

        [HttpPost]
        public ActionResult Create(GroupDB groupdb)
        {
            if (ModelState.IsValid)
            {
                db.Groups.Add(groupdb);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(groupdb);
        }
        
        //
        // GET: /Group/Edit/5
 
        public ActionResult Edit(int id)
        {
            GroupDB groupdb = db.Groups.Find(id);
            return View(groupdb);
        }

        //
        // POST: /Group/Edit/5

        [HttpPost]
        public ActionResult Edit(GroupDB groupdb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(groupdb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groupdb);
        }

        //
        // GET: /Group/Delete/5
 
        public ActionResult Delete(int id)
        {
            GroupDB groupdb = db.Groups.Find(id);
            return View(groupdb);
        }

        //
        // POST: /Group/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            GroupDB groupdb = db.Groups.Find(id);
            db.Groups.Remove(groupdb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}