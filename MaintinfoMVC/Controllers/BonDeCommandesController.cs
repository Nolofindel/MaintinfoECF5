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
using System.Data.Entity.Validation;

namespace MaintinfoMVC.Controllers
{
    public class BonDeCommandesController : Controller
    {
        private MaintinfoContext db = new MaintinfoContext();

        // GET: BonDeCommandes
        public ActionResult Index()
        {
            var bonDeCommandes = db.BonDeCommandes.Include(b => b.ArticleCommande);
            return View(bonDeCommandes.ToList());
        }

        // GET: BonDeCommandes/Details/5
        public ActionResult Details(decimal id)
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
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle");
            return View();
        }


        // GET: BonDeCommandes/Article/
        public ActionResult Article(string id)
        {
            var partialArt = new ArticlePartial();
            Article Art = new Article();
            Art = db.Articles.Find(id);
            partialArt.QuantiteStock = Art.QuantiteArticle;
            partialArt.SeuilMinimal = Art.SeuilMinimal;
            return PartialView("~/Views/PartialView/ArticleDetail.cshtml", partialArt);
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
                try
                {
                    Article Art = new Article();
                    Art = db.Articles.Find(bonDeCommande.Articleid);
                    bonDeCommande.ArticleCommande = Art;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DbEntityValidationException ex)
                {
                    var error = ex.EntityValidationErrors.First().ValidationErrors.First();
                    this.ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    return View(bonDeCommande);
                }
            }

            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonDeCommande.Articleid);
            return View(bonDeCommande);
        }

        // GET: BonDeCommandes/Edit/5
        public ActionResult Edit(decimal id)
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
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonDeCommande.Articleid);
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
            ViewBag.Articleid = new SelectList(db.Articles, "DesignationArticle", "NomArticle", bonDeCommande.Articleid);
            return View(bonDeCommande);
        }

        // GET: BonDeCommandes/Delete/5
        public ActionResult Delete(decimal id)
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
        public ActionResult DeleteConfirmed(decimal id)
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
