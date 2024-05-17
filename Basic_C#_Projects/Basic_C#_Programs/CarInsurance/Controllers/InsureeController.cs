using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities1 db = new InsuranceEntities1();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = 50m;

                if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
                {
                    insuree.Quote += 100m; //if insuree is 18 or under add 100$
                }
                if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 25 && DateTime.Now.Year - insuree.DateOfBirth.Year >= 19)
                {
                    insuree.Quote += 50m; //from ages 19-25 50$ is added
                }
                if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 26)
                {
                    insuree.Quote += 25m;// 26 or older 25$ is added
                }
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25m; //if the car year is before 2000 add 25$
                }
                if(insuree.CarYear > 2015)
                {
                    insuree.Quote += 25m; //if car year is after 2015 add 25$
                }
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25m;//if the car is a porsche add 25$
                }
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25m; // a certain model of a Porsche will add another 25$
                }
                decimal ticketfine = insuree.SpeedingTickets * 10m;//each ticket adds 10$
                if (insuree.SpeedingTickets > 0)
                {
                    insuree.Quote += ticketfine;
                }
                if (insuree.DUI == true)
                {
                    insuree.Quote *= 1.25m; //if user has dui adds 25% to the total
                }
                if (insuree.CoverageType == true)
                {
                    insuree.Quote *= 1.5m; //if they have full coverage add 50% to the total, ouch.
                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        public ActionResult Admin() // so it show the admin page
        {
            return View(db.Insurees.ToList());
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
