﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCtwitter.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Twit", Namespace="http://schemas.datacontract.org/2004/07/TwitterDeneme1")]
    [System.SerializableAttribute()]
    public partial class Twit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string atilmaTarihiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string icerikField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int twitIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string atilmaTarihi {
            get {
                return this.atilmaTarihiField;
            }
            set {
                if ((object.ReferenceEquals(this.atilmaTarihiField, value) != true)) {
                    this.atilmaTarihiField = value;
                    this.RaisePropertyChanged("atilmaTarihi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string icerik {
            get {
                return this.icerikField;
            }
            set {
                if ((object.ReferenceEquals(this.icerikField, value) != true)) {
                    this.icerikField = value;
                    this.RaisePropertyChanged("icerik");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kAdi {
            get {
                return this.kAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.kAdiField, value) != true)) {
                    this.kAdiField = value;
                    this.RaisePropertyChanged("kAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int twitID {
            get {
                return this.twitIDField;
            }
            set {
                if ((this.twitIDField.Equals(value) != true)) {
                    this.twitIDField = value;
                    this.RaisePropertyChanged("twitID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Kullanici", Namespace="http://schemas.datacontract.org/2004/07/TwitterDeneme1")]
    [System.SerializableAttribute()]
    public partial class Kullanici : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kullaniciAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parolaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int uyeIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kullaniciAdi {
            get {
                return this.kullaniciAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.kullaniciAdiField, value) != true)) {
                    this.kullaniciAdiField = value;
                    this.RaisePropertyChanged("kullaniciAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parola {
            get {
                return this.parolaField;
            }
            set {
                if ((object.ReferenceEquals(this.parolaField, value) != true)) {
                    this.parolaField = value;
                    this.RaisePropertyChanged("parola");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int uyeID {
            get {
                return this.uyeIDField;
            }
            set {
                if ((this.uyeIDField.Equals(value) != true)) {
                    this.uyeIDField = value;
                    this.RaisePropertyChanged("uyeID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITwitter")]
    public interface ITwitter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/KullaniciKayit", ReplyAction="http://tempuri.org/ITwitter/KullaniciKayitResponse")]
        bool KullaniciKayit(string kullaniciAdi, string parola, string email, string ad, string soyad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/KullaniciKayit", ReplyAction="http://tempuri.org/ITwitter/KullaniciKayitResponse")]
        System.Threading.Tasks.Task<bool> KullaniciKayitAsync(string kullaniciAdi, string parola, string email, string ad, string soyad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/KullaniciGiris", ReplyAction="http://tempuri.org/ITwitter/KullaniciGirisResponse")]
        int KullaniciGiris(string kullanici, string parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/KullaniciGiris", ReplyAction="http://tempuri.org/ITwitter/KullaniciGirisResponse")]
        System.Threading.Tasks.Task<int> KullaniciGirisAsync(string kullanici, string parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/TwitAt", ReplyAction="http://tempuri.org/ITwitter/TwitAtResponse")]
        MVCtwitter.ServiceReference1.Twit TwitAt(string icerik, int uyeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/TwitAt", ReplyAction="http://tempuri.org/ITwitter/TwitAtResponse")]
        System.Threading.Tasks.Task<MVCtwitter.ServiceReference1.Twit> TwitAtAsync(string icerik, int uyeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/TwitFav", ReplyAction="http://tempuri.org/ITwitter/TwitFavResponse")]
        bool TwitFav(int uyeID, int twitID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/TwitFav", ReplyAction="http://tempuri.org/ITwitter/TwitFavResponse")]
        System.Threading.Tasks.Task<bool> TwitFavAsync(int uyeID, int twitID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/UyeTakip", ReplyAction="http://tempuri.org/ITwitter/UyeTakipResponse")]
        bool UyeTakip(int takipEdenID, int takipEdilenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/UyeTakip", ReplyAction="http://tempuri.org/ITwitter/UyeTakipResponse")]
        System.Threading.Tasks.Task<bool> UyeTakipAsync(int takipEdenID, int takipEdilenID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/tumTwitleriCek", ReplyAction="http://tempuri.org/ITwitter/tumTwitleriCekResponse")]
        MVCtwitter.ServiceReference1.Twit[] tumTwitleriCek(int uyeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/tumTwitleriCek", ReplyAction="http://tempuri.org/ITwitter/tumTwitleriCekResponse")]
        System.Threading.Tasks.Task<MVCtwitter.ServiceReference1.Twit[]> tumTwitleriCekAsync(int uyeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/Kullanicilar", ReplyAction="http://tempuri.org/ITwitter/KullanicilarResponse")]
        MVCtwitter.ServiceReference1.Kullanici[] Kullanicilar(int uyeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITwitter/Kullanicilar", ReplyAction="http://tempuri.org/ITwitter/KullanicilarResponse")]
        System.Threading.Tasks.Task<MVCtwitter.ServiceReference1.Kullanici[]> KullanicilarAsync(int uyeID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITwitterChannel : MVCtwitter.ServiceReference1.ITwitter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TwitterClient : System.ServiceModel.ClientBase<MVCtwitter.ServiceReference1.ITwitter>, MVCtwitter.ServiceReference1.ITwitter {
        
        public TwitterClient() {
        }
        
        public TwitterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TwitterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TwitterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TwitterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool KullaniciKayit(string kullaniciAdi, string parola, string email, string ad, string soyad) {
            return base.Channel.KullaniciKayit(kullaniciAdi, parola, email, ad, soyad);
        }
        
        public System.Threading.Tasks.Task<bool> KullaniciKayitAsync(string kullaniciAdi, string parola, string email, string ad, string soyad) {
            return base.Channel.KullaniciKayitAsync(kullaniciAdi, parola, email, ad, soyad);
        }
        
        public int KullaniciGiris(string kullanici, string parola) {
            return base.Channel.KullaniciGiris(kullanici, parola);
        }
        
        public System.Threading.Tasks.Task<int> KullaniciGirisAsync(string kullanici, string parola) {
            return base.Channel.KullaniciGirisAsync(kullanici, parola);
        }
        
        public MVCtwitter.ServiceReference1.Twit TwitAt(string icerik, int uyeID) {
            return base.Channel.TwitAt(icerik, uyeID);
        }
        
        public System.Threading.Tasks.Task<MVCtwitter.ServiceReference1.Twit> TwitAtAsync(string icerik, int uyeID) {
            return base.Channel.TwitAtAsync(icerik, uyeID);
        }
        
        public bool TwitFav(int uyeID, int twitID) {
            return base.Channel.TwitFav(uyeID, twitID);
        }
        
        public System.Threading.Tasks.Task<bool> TwitFavAsync(int uyeID, int twitID) {
            return base.Channel.TwitFavAsync(uyeID, twitID);
        }
        
        public bool UyeTakip(int takipEdenID, int takipEdilenID) {
            return base.Channel.UyeTakip(takipEdenID, takipEdilenID);
        }
        
        public System.Threading.Tasks.Task<bool> UyeTakipAsync(int takipEdenID, int takipEdilenID) {
            return base.Channel.UyeTakipAsync(takipEdenID, takipEdilenID);
        }
        
        public MVCtwitter.ServiceReference1.Twit[] tumTwitleriCek(int uyeID) {
            return base.Channel.tumTwitleriCek(uyeID);
        }
        
        public System.Threading.Tasks.Task<MVCtwitter.ServiceReference1.Twit[]> tumTwitleriCekAsync(int uyeID) {
            return base.Channel.tumTwitleriCekAsync(uyeID);
        }
        
        public MVCtwitter.ServiceReference1.Kullanici[] Kullanicilar(int uyeID) {
            return base.Channel.Kullanicilar(uyeID);
        }
        
        public System.Threading.Tasks.Task<MVCtwitter.ServiceReference1.Kullanici[]> KullanicilarAsync(int uyeID) {
            return base.Channel.KullanicilarAsync(uyeID);
        }
    }
}