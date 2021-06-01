using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto04.DATE;
using Proyecto04.Models;

namespace Proyecto04.Controllers
{
    public class DBclientesController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: DBclientes
        public async Task<ActionResult> Index()
        {
            return View(await db.Proyecto04.ToListAsync());
        }

        // GET: DBclientes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBclientesYULY dBclientesYULY = await db.Proyecto04.FindAsync(id);
            if (dBclientesYULY == null)
            {
                return HttpNotFound();
            }
            return View(dBclientesYULY);
        }

        // GET: DBclientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DBclientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdDocumento,Nombres,Apellidos")] DBclientesYULY dBclientesYULY)
        {
            if (ModelState.IsValid)
            {
                db.Proyecto04.Add(dBclientesYULY);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dBclientesYULY);
        }

        // GET: DBclientes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBclientesYULY dBclientesYULY = await db.Proyecto04.FindAsync(id);
            if (dBclientesYULY == null)
            {
                return HttpNotFound();
            }
            return View(dBclientesYULY);
        }

        // POST: DBclientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdDocumento,Nombres,Apellidos")] DBclientesYULY dBclientesYULY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dBclientesYULY).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dBclientesYULY);
        }

        // GET: DBclientes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBclientesYULY dBclientesYULY = await db.Proyecto04.FindAsync(id);
            if (dBclientesYULY == null)
            {
                return HttpNotFound();
            }
            return View(dBclientesYULY);
        }

        // POST: DBclientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DBclientesYULY dBclientesYULY = await db.Proyecto04.FindAsync(id);
            db.Proyecto04.Remove(dBclientesYULY);
            await db.SaveChangesAsync();
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
