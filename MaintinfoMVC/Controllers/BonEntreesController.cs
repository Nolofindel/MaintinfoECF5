using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MaintinfoBo;
using MaintinfoDAL;

namespace MaintinfoMVC.Controllers
{
    public class BonEntreesController : Controller
    {
        private MaintinfoContext db = new MaintinfoContext();

        // GET: BonEntrees
        public ActionResult Index()
        {
            var bonEntrees = db.BonEntrees.Include(b => b.ArticleEntree);
            return View(bonEntrees.ToList());
        }

        // GET: BonEntrees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonEntree bonEntree = db.BonEntrees.Find(id);
            if (bonEntree == null)
            {
                return HttpNotFound();
            }
            return View(bonEntree);
        }

        // GET: BonEntrees/Create
        public ActionResult Create()
        {
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle");
            return View();
        }

        // POST: BonEntrees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumEntree,QuantiteEntree,DateEntree,Articleid")] BonEntree bonEntree)
        {
            if (ModelState.IsValid)
            {
                db.BonEntrees.Add(bonEntree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonEntree.Articleid);
            return View(bonEntree);
        }

        // GET: BonEntrees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonEntree bonEntree = db.BonEntrees.Find(id);
            if (bonEntree == null)
            {
                return HttpNotFound();
            }
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonEntree.Articleid);
            return View(bonEntree);
        }

        // POST: BonEntrees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumEntree,QuantiteEntree,DateEntree,Articleid")] BonEntree bonEntree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bonEntree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonEntree.Articleid);
            return View(bonEntree);
        }

        // GET: BonEntrees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonEntree bonEntree = db.BonEntrees.Find(id);
            if (bonEntree == null)
            {
                return HttpNotFound();
            }
            return View(bonEntree);
        }

        // POST: BonEntrees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BonEntree bonEntree = db.BonEntrees.Find(id);
            db.BonEntrees.Remove(bonEntree);
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
