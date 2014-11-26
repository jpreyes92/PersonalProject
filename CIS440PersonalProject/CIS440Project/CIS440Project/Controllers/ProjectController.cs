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
    [Authorize(Roles= "Admin")]
    public class ProjectController : Controller
    {
        private Project2DBContext db = new Project2DBContext();

        //
        // GET: /Project/

        public ViewResult Index()
        {
            return View(db.Projects.ToList());
        }

        //
        // GET: /Project/Details/5

        public ViewResult Details(int id)
        {
            ProjectDB projectdb = db.Projects.Find(id);
            return View(projectdb);
        }

        //
        // GET: /Project/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Project/Create

        [HttpPost]
        public ActionResult Create(ProjectDB projectdb)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(projectdb);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(projectdb);
        }
        
        //
        // GET: /Project/Edit/5
 
        public ActionResult Edit(int id)
        {
            ProjectDB projectdb = db.Projects.Find(id);
            return View(projectdb);
        }

        //
        // POST: /Project/Edit/5

        [HttpPost]
        public ActionResult Edit(ProjectDB projectdb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectdb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectdb);
        }

        //
        // GET: /Project/Delete/5
 
        public ActionResult Delete(int id)
        {
            ProjectDB projectdb = db.Projects.Find(id);
            return View(projectdb);
        }

        //
        // POST: /Project/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ProjectDB projectdb = db.Projects.Find(id);
            db.Projects.Remove(projectdb);
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