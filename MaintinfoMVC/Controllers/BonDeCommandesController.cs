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
    public class BonDeCommandesController : Controller
    {
        private MaintinfoContext db = new MaintinfoContext();

        // GET: BonDeCommandes
        public ActionResult Index()
        {
            return View(db.BonDeCommandes.ToList());
        }

        // GET: BonDeCommandes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonDeCommande bonDeCommande = db.BonDeCommandes.Find(id);
            if (bonDeCommande == null)
            {
                return HttpNotFound();
            }
            return View(bonDeCommande);
        }

        // GET: BonDeCommandes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BonDeCommandes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumCommande,DateCommande,QuantiteCommande,CommandeEffectue,Articleid")] BonDeCommande bonDeCommande)
        {
            if (ModelState.IsValid)
            {
                db.BonDeCommandes.Add(bonDeCommande);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bonDeCommande);
        }

        // GET: BonDeCommandes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonDeCommande bonDeCommande = db.BonDeCommandes.Find(id);
            if (bonDeCommande == null)
            {
                return HttpNotFound();
            }
            return View(bonDeCommande);
        }

        // POST: BonDeCommandes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumCommande,DateCommande,QuantiteCommande,CommandeEffectue,Articleid")] BonDeCommande bonDeCommande)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bonDeCommande).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bonDeCommande);
        }

        // GET: BonDeCommandes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BonDeCommande bonDeCommande = db.BonDeCommandes.Find(id);
            if (bonDeCommande == null)
            {
                return HttpNotFound();
            }
            return View(bonDeCommande);
        }

        // POST: BonDeCommandes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BonDeCommande bonDeCommande = db.BonDeCommandes.Find(id);
            db.BonDeCommandes.Remove(bonDeCommande);
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
