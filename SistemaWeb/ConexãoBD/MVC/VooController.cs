using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTP.Models;

namespace MVCTP.Controllers
{
    public class VoosController : Controller
    {
        private VooDbContext db = new VooDbContext();

        // GET: Voos
        public ActionResult Index()
        {
            return View(db.Voos.ToList());
        }

        // GET: Voos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voo voo = db.Voos.Find(id);
            if (voo == null)
            {
                return HttpNotFound();
            }
            return View(voo);
        }

        // GET: Voos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Voos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cdvoo,cdcia,dtvoo,lcori,lcdes,cdaero,vlpass")] Voo voo)
        {
            if (ModelState.IsValid)
            {
                db.Voos.Add(voo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(voo);
        }

        // GET: Voos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voo voo = db.Voos.Find(id);
            if (voo == null)
            {
                return HttpNotFound();
            }
            return View(voo);
        }

        // POST: Voos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cdvoo,cdcia,dtvoo,lcori,lcdes,cdaero,vlpass")] Voo voo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(voo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(voo);
        }

        // GET: Voos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voo voo = db.Voos.Find(id);
            if (voo == null)
            {
                return HttpNotFound();
            }
            return View(voo);
        }

        // POST: Voos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Voo voo = db.Voos.Find(id);
            db.Voos.Remove(voo);
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
