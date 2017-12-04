using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TwitterDeneme1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITwitter" in both code and config file together.
    [ServiceContract]
    public interface ITwitter
    {
        [OperationContract]
        bool KullaniciKayit(string kullaniciAdi, string parola, string email, string ad, string soyad);

        [OperationContract]
        int KullaniciGiris(string kullanici, string parola);

        [OperationContract]
        Twit TwitAt(string icerik, int uyeID);

        [OperationContract]
        bool TwitFav(int uyeID, int twitID);

        [OperationContract]
        bool UyeTakip(int takipEdenID, int takipEdilenID);

        [OperationContract]
        List<Twit> tumTwitleriCek(int uyeID);

        [OperationContract]
        List<Kullanici> Kullanicilar(int uyeID);
    }
}
