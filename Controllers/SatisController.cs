﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LSYS.Models.Entity;
namespace LSYS.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        LSYSEntities db = new LSYSEntities();
        public ActionResult Index(Nullable<int> id)
        {
            var byi = from k in db.TBL_SATIS
                       where k.BAYI_ID == id
                       select k;

            return View(byi.ToList());
        }
        

        [HttpGet]
        public ActionResult SatisEkle()
        {
            
            //List<SelectListItem> deger1 = (from i in db.TBL_BAYI.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = i.BAYI_ADI,
            //                                   Value = i.BAYI_ID.ToString()
            //                               }).ToList();
            //ViewBag.dgr1 = deger1;
           
            return View();
        }
        [HttpPost]
        public ActionResult SatisEkle(TBL_SATIS p)
        {            
            db.TBL_SATIS.Add(p);
            db.SaveChanges();

            return View();
        }

        //public ActionResult SatisGetir(Nullable<int> id)
        //{
        //    var sts = db.TBL_SATIS.Find(id);
        //    return View("SatisGetir", sts);
        //}
        //public ActionResult SatisGuncelle(TBL_SATIS p)
        //{
        //    var sts = db.TBL_SATIS.Find(p.SATIS_ID);
        //    sts.MUSTERI_ID = p.MUSTERI_ID;
        //    sts.URUN_ID = p.URUN_ID;
        //    sts.ADET = p.ADET;
        //    sts.SATIS_TARIH = p.SATIS_TARIH;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }


}