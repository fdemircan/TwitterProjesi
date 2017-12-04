using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TwitterDeneme1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Twitter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Twitter.svc or Twitter.svc.cs at the Solution Explorer and start debugging.
    public class Twitter : ITwitter
    {
        dbTwitterEntitiesSOA t = new dbTwitterEntitiesSOA();

        public bool KullaniciKayit(string kullaniciAdi, string parola, string email, string ad, string soyad)
        {
            tblUye u = new tblUye();
            u.ad = ad;
            u.soyad = soyad;
            u.email = email;
            u.kullaniciAdi = kullaniciAdi;
            u.parola = parola;

            t.tblUye.Add(u);
            t.SaveChanges();

            return true;
        }

        public int KullaniciGiris(string kullanici, string parola)
        {
            if(t.tblUye.Any(x=>(x.kullaniciAdi==kullanici || x.email==kullanici) && x.parola==parola))
            {
                return t.tblUye.FirstOrDefault(x => (x.kullaniciAdi == kullanici || x.email == kullanici) && x.parola == parola).uyeID;
            }
            return 0;
        }

        public Twit TwitAt(string icerik, int uyeID)
        {
            tblTwit twit = new tblTwit();
            twit.icerik = icerik;
            twit.uyeID = uyeID;
            twit.atilmaTarihi = DateTime.Now;

            t.tblTwit.Add(twit);
            t.SaveChanges();

            Twit tw = new Twit();
            tw.kAdi = t.tblUye.FirstOrDefault(x => x.uyeID == uyeID).kullaniciAdi;
            tw.icerik = twit.icerik;
            
            return tw;
        }

        public bool TwitFav(int uyeID, int twitID)
        {

            if(t.tblTwitFav.Any(x=>x.uyeID==uyeID && x.twitID==twitID))
            {
                tblTwitFav tf1 = t.tblTwitFav.FirstOrDefault(x => x.uyeID==uyeID && x.twitID == twitID);
                t.tblTwitFav.Remove(tf1);
                t.SaveChanges();
            }
            else
            {
                tblTwitFav tf2 = new tblTwitFav();
                tf2.uyeID = uyeID;
                tf2.twitID = twitID;
                t.tblTwitFav.Add(tf2);
                t.SaveChanges();
            }
            return true;
        }

        public bool UyeTakip(int takipEdenID, int takipEdilenID)
        {
            if(t.tblUyeTakip.Any(x=>x.takipEdenID==takipEdenID && x.takipEdilenID==takipEdilenID))
            {
                tblUyeTakip ut = t.tblUyeTakip.FirstOrDefault(x => x.takipEdenID == x.takipEdenID && x.takipEdilenID == takipEdilenID);
                t.tblUyeTakip.Remove(ut);
                t.SaveChanges();
            }
            else
            {
                tblUyeTakip ut2 = new tblUyeTakip();
                ut2.takipEdenID = takipEdenID;
                ut2.takipEdilenID = takipEdilenID;
                t.tblUyeTakip.Add(ut2);
                t.SaveChanges();
            }

            return true;
        }

        public List<Twit> tumTwitleriCek(int uyeID)
        {
            List<Twit> twitler = new List<Twit>();
            foreach (tblUyeTakip i in t.tblUyeTakip.Where(x=>x.takipEdenID==uyeID))
            {
                foreach (tblTwit j in t.tblTwit.Where(x=>x.uyeID==i.takipEdilenID))
                {
                    Twit t1 = new Twit();
                    t1.twitID = j.twitID;
                    t1.icerik=j.icerik;
                    t1.atilmaTarihi=j.atilmaTarihi.Value.ToString();
                    t1.kAdi = j.tblUye.kullaniciAdi;
                    twitler.Add(t1);
                }
            }
            return twitler.OrderByDescending(x=>x.twitID).ToList();
        }
        public List<Kullanici> Kullanicilar(int uyeID)
        {
            List<Kullanici> kullanicilar = new List<Kullanici>();
            foreach (tblUye i in t.tblUye)
            {
                Kullanici k = new Kullanici();
                k.kullaniciAdi = i.kullaniciAdi;
                k.email = i.email;
                k.parola = i.parola;
                kullanicilar.Add(k);
            }
            return kullanicilar.ToList();
        }
    }
}
