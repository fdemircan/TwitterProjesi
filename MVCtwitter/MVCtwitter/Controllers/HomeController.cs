using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCtwitter.ServiceReference;

namespace MVCtwitter.Controllers
{
    public class HomeController : Controller
    {
        TwitterClient tc = new TwitterClient();
        public ActionResult Index()
        {
            Session["id"] = 1;
            ViewBag.twitler = tc.tumTwitleriCek(Convert.ToInt32(Session["id"]));
            return View();
        }

        public ActionResult KayitOl()
        {
            return View();
        }


        public int Kayit(string kullaniciAdi,string parola, string email, string ad, string soyad)
        {
            if (tc.KullaniciKayit(kullaniciAdi,parola,email,ad,soyad))
                return 1;
            else return 0;
            
        }

        public int GirisYap(string kullanici, string parola)
        {
            int id = tc.KullaniciGiris(kullanici, parola);
            if (id == 0)
                return 0;
            else
            {
                Session["id"] = id;
                return 1;
            }
        }

        public ActionResult CikisYap()
        {
            Session.Clear();
            Session.Abandon();
            return Redirect("/Home/Index") ;
        }

        public ActionResult twitler()
        {
            ViewBag.twitler = tc.tumTwitleriCek(Convert.ToInt32(Session["id"]));
            return View();
        }

        public JsonResult TwitAt(string icerik)
        {
            Twit t = tc.TwitAt(icerik,Convert.ToInt32(Session["id"]));
            var jsonModel = new { 
                icerik=t.icerik,
                kAdi=t.kAdi
            };
            return Json(jsonModel, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TwitFav()
        {
            return View();
        }

        public JsonResult twitiFavaEkle(int twitID)
        {
            var sonuc = new
            {
                donus = tc.TwitFav(Convert.ToInt32(Session["id"]), twitID)
            };
           
            return Json(sonuc,JsonRequestBehavior.AllowGet);
        }
        
       public ActionResult kullaniciAra(string aranacakKelime)
        {
           ViewBag.kullaniciAra = tc.Kullanicilar(Convert.ToInt32(Session["id"]));

           var kullanicilar = tc.Kullanicilar(Convert.ToInt32(Session["id"]));
           var kullaniciAra = from k in kullanicilar select k;

           if (!String.IsNullOrEmpty(aranacakKelime))
           {
               kullaniciAra = kullaniciAra.Where(x => x.kullaniciAdi.Contains(aranacakKelime));
           }

           return View("kullaniciAra");
        }

    }
}