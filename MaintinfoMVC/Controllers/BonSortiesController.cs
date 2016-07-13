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
    public class BonSortiesController : Controller
    {
        private MaintinfoContext db = new MaintinfoContext();

        // GET: BonSorties
        public ActionResult Index()
        {
            var bonSorties = db.BonSorties.Include(b => b.ArticleSortie).Include(b => b.Depanneur);
            return View(bonSorties.ToList());
        }

        // GET: BonSorties/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonSortie bonSortie = db.BonSorties.Find(id);
            if (bonSortie == null)
            {
                return HttpNotFound();
            }
            return View(bonSortie);
        }

        // GET: BonSorties/Create
        public ActionResult Create()
        {
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle");
            ViewBag.NumDepanneur = new SelectList(db.Depanneurs, "MatriculeDepanneur", "NomDepanneur");
            return View();
        }

        // POST: BonSorties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumSortie,QuantiteSortie,DateDemande,Articleid,NumDepanneur")] BonSortie bonSortie)
        {
            if (ModelState.IsValid)
            {
                db.BonSorties.Add(bonSortie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonSortie.Articleid);
            ViewBag.NumDepanneur = new SelectList(db.Depanneurs, "MatriculeDepanneur", "NomDepanneur", bonSortie.NumDepanneur);
            return View(bonSortie);
        }

        // GET: BonSorties/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonSortie bonSortie = db.BonSorties.Find(id);
            if (bonSortie == null)
            {
                return HttpNotFound();
            }
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonSortie.Articleid);
            ViewBag.NumDepanneur = new SelectList(db.Depanneurs, "MatriculeDepanneur", "NomDepanneur", bonSortie.NumDepanneur);
            return View(bonSortie);
        }

        // POST: BonSorties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumSortie,QuantiteSortie,DateDemande,Articleid,NumDepanneur")] BonSortie bonSortie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bonSortie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonSortie.Articleid);
            ViewBag.NumDepanneur = new SelectList(db.Depanneurs, "MatriculeDepanneur", "NomDepanneur", bonSortie.NumDepanneur);
            return View(bonSortie);
        }

        // GET: BonSorties/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonSortie bonSortie = db.BonSorties.Find(id);
            if (bonSortie == null)
            {
                return HttpNotFound();
            }
            return View(bonSortie);
        }

        // POST: BonSorties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BonSortie bonSortie = db.BonSorties.Find(id);
            db.BonSorties.Remove(bonSortie);
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
