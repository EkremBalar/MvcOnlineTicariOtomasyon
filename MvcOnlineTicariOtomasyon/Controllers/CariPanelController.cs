using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CariPanelController : Controller
    {
        // GET: CariPanel


        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {

            var mail = (string)Session["CariMail"];
            var degerler = c.Carilers.Where(x => x.CariMail == mail).ToList();

            ViewBag.m = mail;
            return View(degerler);
        }

        public ActionResult Siparislerim()
        {

            var mail = (string)Session["CariMail"];
            var id = c.Carilers.Where(x => x.CariMail == mail.ToString()).Select(y => y.CariId).FirstOrDefault();
            var degerler = c.SatisHarekets.Where(x => x.Cariid == id).ToList();
            return View();
        }
        public ActionResult KargoTakip(string p )
        {
            var k = from x in c.KargoDetays select x;
            
            
                k = k.Where(y => y.TakipKodu.Contains(p));
            
            return View(k.ToList());
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }



    }
}