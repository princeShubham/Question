using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Question.Models;

namespace Question.Controllers
{
    public class SkillGroupsController : Controller
    {
        private DashBoardDbContext db = new DashBoardDbContext();

        // GET: SkillGroups
        public ActionResult Index()
        {
            return View(db.SkillGroups.ToList());
        }

        // GET: SkillGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillGroup skillGroup = db.SkillGroups.Find(id);
            if (skillGroup == null)
            {
                return HttpNotFound();
            }
            return View(skillGroup);
        }

        // GET: SkillGroups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SkillGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SkillGroupId,SkillGroupName,Skill,Mode")] SkillGroup skillGroup)
        {
            if (ModelState.IsValid)
            {
                db.SkillGroups.Add(skillGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skillGroup);
        }

        // GET: SkillGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillGroup skillGroup = db.SkillGroups.Find(id);
            if (skillGroup == null)
            {
                return HttpNotFound();
            }
            return View(skillGroup);
        }

        // POST: SkillGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SkillGroupId,SkillGroupName,Skill,Mode")] SkillGroup skillGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skillGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skillGroup);
        }

        // GET: SkillGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillGroup skillGroup = db.SkillGroups.Find(id);
            if (skillGroup == null)
            {
                return HttpNotFound();
            }
            return View(skillGroup);
        }

        // POST: SkillGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SkillGroup skillGroup = db.SkillGroups.Find(id);
            db.SkillGroups.Remove(skillGroup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
