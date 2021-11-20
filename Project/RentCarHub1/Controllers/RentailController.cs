using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCarHub1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarHub1.Controllers
{
    public class RentailController : Controller
    {
        RentCarContext db = new RentCarContext();
        // GET: Rentail
        public ActionResult Index()
        {
            var result = (from r in db.Rentails
                          join c in db.Carregs on r.Carid equals c.Carno
                          select new RentailViewModel
                          {
                              Id = r.Id,
                              Carid = r.Carid,
                              Custid = r.Custid,
                              Fee = r.Fee,
                              Sdate = r.Sdate,
                              Edate = r.Edate,
                              Available = c.Available
                          }).ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult Getcar()
        {
            var car = db.Carregs.ToList();
            return Json(car);
        }

        [HttpPost]
        public ActionResult Getid(int id)
        {
            var customer = (from s in db.Customers where s.Id == id select s.Cutname).ToList();
            return Json(customer);
        }

        [HttpPost]
        public ActionResult Getavail(string carno)
        {
            var caravail = (from s in db.Carregs where s.Carno == carno select s.Available).FirstOrDefault();
            return Json(caravail);
        }

        [HttpPost]
        public ActionResult Save(Rentail rent)
        {
            if (ModelState.IsValid)
            {
                db.Rentails.Add(rent);
                var car = db.Carregs.SingleOrDefault(e => e.Carno == rent.Carid);


                car.Available = "no";
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rent);
        }
    }
}
