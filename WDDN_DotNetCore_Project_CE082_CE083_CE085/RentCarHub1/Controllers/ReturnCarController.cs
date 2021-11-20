using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCarHub1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarHub1.Controllers
{
    public class ReturnCarController : Controller
    {
        RentCarContext db = new RentCarContext();
        // GET: ReturnCar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(Returncar recar)
        {
            if (ModelState.IsValid)
            {
                db.Returncars.Add(recar);
                var car = db.Carregs.SingleOrDefault(e => e.Carno == recar.Carno);


                car.Available = "yes";
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recar);
        }



        [HttpPost]
        public ActionResult Getid(string carno)
        {
            var cars = (from s in db.Rentails
                        where s.Carid == carno
                        select new
                        {
                            startdate = s.Sdate,
                            enddate = s.Edate,
                            custid = s.Custid,
                            carno = s.Carid,
                            fee = s.Fee,
                        }).ToArray();
            return Json(cars);
        }
    }
}
