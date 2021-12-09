using AdminPageDemo0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPageDemo0.Controllers
{
    public class ChuyenBayController : Controller
    {
        AirDB db = new AirDB();
        // GET: ChuyenBay
        public ActionResult Index()
        {
            return View(db.ChuyenBays.ToList());
        }

        public ActionResult Edit(long id)
        {
            var chuyenBay = db.ChuyenBays.Where(c => c.MaChuyenBay == id).FirstOrDefault();
            return View(chuyenBay);
        }

        [HttpPost]
        public ActionResult Edit(ChuyenBay chuyenBay)
        {
            var preData = db.ChuyenBays.Where(c => c.MaChuyenBay == chuyenBay.MaChuyenBay).FirstOrDefault();
            preData.DiemDi = chuyenBay.DiemDi;
            preData.DiemDen = chuyenBay.DiemDen;
            preData.ThoiGianDi = chuyenBay.ThoiGianDi;
            preData.ThoiGianDen = chuyenBay.ThoiGianDen;
            preData.MaMayBay = chuyenBay.MaMayBay;
            preData.Gia = chuyenBay.Gia;

            db.SaveChanges();
            /*if(preData == null)
            {
                return RedirectToAction("Edit");
            }*/
            return RedirectToAction("Index");
        }

        public ActionResult Delete(long id)
        {
            var chuyenBay = db.ChuyenBays.Where(c => c.MaChuyenBay == id).FirstOrDefault();
            db.ChuyenBays.Remove(chuyenBay);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ChuyenBay chuyenBay)
        {
            db.ChuyenBays.Add(chuyenBay);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}