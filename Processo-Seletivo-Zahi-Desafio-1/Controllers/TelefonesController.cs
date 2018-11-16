using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Processo_Seletivo_Zahi_Desafio_1.Models;
using Zahi_Desafio_1.Models;

namespace Processo_Seletivo_Zahi_Desafio_1.Controllers
{
    public class TelefonesController : Controller
    {
        private Processo_Seletivo_Zahi_Desafio_1Context db = new Processo_Seletivo_Zahi_Desafio_1Context();

        // GET: Telefones
        public ActionResult Index()
        {
            var telefones = db.Telefones.Include(t => t.Cliente);
            return View(telefones.ToList());
        }

        // GET: Telefones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefone telefone = db.Telefones.Find(id);
            if (telefone == null)
            {
                return HttpNotFound();
            }
            return View(telefone);
        }

        // GET: Telefones/Create
        public ActionResult Create()
        {
            ViewBag.Client_ID = new SelectList(db.Clientes, "Client_ID", "Client_Name");
            return View();
        }

        // POST: Telefones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Telefone_ID,DDD,Telefone_Number,Client_ID")] Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                db.Telefones.Add(telefone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Client_ID = new SelectList(db.Clientes, "Client_ID", "Client_Name", telefone.Client_ID);
            return View(telefone);
        }

        // GET: Telefones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefone telefone = db.Telefones.Find(id);
            if (telefone == null)
            {
                return HttpNotFound();
            }
            ViewBag.Client_ID = new SelectList(db.Clientes, "Client_ID", "Client_Name", telefone.Client_ID);
            return View(telefone);
        }

        // POST: Telefones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Telefone_ID,DDD,Telefone_Number,Client_ID")] Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(telefone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Client_ID = new SelectList(db.Clientes, "Client_ID", "Client_Name", telefone.Client_ID);
            return View(telefone);
        }

        // GET: Telefones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefone telefone = db.Telefones.Find(id);
            if (telefone == null)
            {
                return HttpNotFound();
            }
            return View(telefone);
        }

        // POST: Telefones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Telefone telefone = db.Telefones.Find(id);
            db.Telefones.Remove(telefone);
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
