﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newTTSproject.HaberService1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HaberService1.AkıllıHaberSoap")]
    public interface AkıllıHaberSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/YazarArama", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet YazarArama(string kullaniciadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/YazarArama", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> YazarAramaAsync(string kullaniciadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Kategori", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Kategori();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Kategori", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> KategoriAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Yazar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Yazar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Yazar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> YazarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteÜye", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet DeleteÜye(string kullaniciadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteÜye", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> DeleteÜyeAsync(string kullaniciadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteKategori", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet DeleteKategori(string kategoriadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteKategori", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> DeleteKategoriAsync(string kategoriadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteYazar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet DeleteYazar(string yazaradi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteYazar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> DeleteYazarAsync(string yazaradi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddKategori", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AddKategori(string kategoriadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddKategori", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddKategoriAsync(string kategoriadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddYazar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AddYazar(string yazaradi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddYazar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddYazarAsync(string yazaradi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSecim", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSecim(string yazaradi, string kategoriadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSecim", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSecimAsync(string yazaradi, string kategoriadi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMakale", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetMakale(string baslik, string icerik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMakale", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetMakaleAsync(string baslik, string icerik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMembers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        newTTSproject.HaberService1.Üye[] GetMembers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMembers", ReplyAction="*")]
        System.Threading.Tasks.Task<newTTSproject.HaberService1.Üye[]> GetMembersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MemberDogrula", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool MemberDogrula(string kullaniciadi, string sifre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MemberDogrula", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> MemberDogrulaAsync(string kullaniciadi, string sifre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AddMember(string ad, string soyad, string email, string kullaniciadi, string sifre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddMember", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddMemberAsync(string ad, string soyad, string email, string kullaniciadi, string sifre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddMakale", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AddMakale(int yazarid, int kategoriid, string baslik, string icerik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddMakale", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddMakaleAsync(int yazarid, int kategoriid, string baslik, string icerik);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Üye : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int üyeIDField;
        
        private string adField;
        
        private string soyadField;
        
        private string emailField;
        
        private string kullaniciAdiField;
        
        private string sifreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ÜyeID {
            get {
                return this.üyeIDField;
            }
            set {
                this.üyeIDField = value;
                this.RaisePropertyChanged("ÜyeID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Ad {
            get {
                return this.adField;
            }
            set {
                this.adField = value;
                this.RaisePropertyChanged("Ad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Soyad {
            get {
                return this.soyadField;
            }
            set {
                this.soyadField = value;
                this.RaisePropertyChanged("Soyad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string KullaniciAdi {
            get {
                return this.kullaniciAdiField;
            }
            set {
                this.kullaniciAdiField = value;
                this.RaisePropertyChanged("KullaniciAdi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Sifre {
            get {
                return this.sifreField;
            }
            set {
                this.sifreField = value;
                this.RaisePropertyChanged("Sifre");
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
    public interface AkıllıHaberSoapChannel : newTTSproject.HaberService1.AkıllıHaberSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AkıllıHaberSoapClient : System.ServiceModel.ClientBase<newTTSproject.HaberService1.AkıllıHaberSoap>, newTTSproject.HaberService1.AkıllıHaberSoap {
        
        public AkıllıHaberSoapClient() {
        }
        
        public AkıllıHaberSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AkıllıHaberSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AkıllıHaberSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AkıllıHaberSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet YazarArama(string kullaniciadi) {
            return base.Channel.YazarArama(kullaniciadi);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> YazarAramaAsync(string kullaniciadi) {
            return base.Channel.YazarAramaAsync(kullaniciadi);
        }
        
        public System.Data.DataSet Kategori() {
            return base.Channel.Kategori();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> KategoriAsync() {
            return base.Channel.KategoriAsync();
        }
        
        public System.Data.DataSet Yazar() {
            return base.Channel.Yazar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> YazarAsync() {
            return base.Channel.YazarAsync();
        }
        
        public System.Data.DataSet DeleteÜye(string kullaniciadi) {
            return base.Channel.DeleteÜye(kullaniciadi);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DeleteÜyeAsync(string kullaniciadi) {
            return base.Channel.DeleteÜyeAsync(kullaniciadi);
        }
        
        public System.Data.DataSet DeleteKategori(string kategoriadi) {
            return base.Channel.DeleteKategori(kategoriadi);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DeleteKategoriAsync(string kategoriadi) {
            return base.Channel.DeleteKategoriAsync(kategoriadi);
        }
        
        public System.Data.DataSet DeleteYazar(string yazaradi) {
            return base.Channel.DeleteYazar(yazaradi);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DeleteYazarAsync(string yazaradi) {
            return base.Channel.DeleteYazarAsync(yazaradi);
        }
        
        public bool AddKategori(string kategoriadi) {
            return base.Channel.AddKategori(kategoriadi);
        }
        
        public System.Threading.Tasks.Task<bool> AddKategoriAsync(string kategoriadi) {
            return base.Channel.AddKategoriAsync(kategoriadi);
        }
        
        public bool AddYazar(string yazaradi) {
            return base.Channel.AddYazar(yazaradi);
        }
        
        public System.Threading.Tasks.Task<bool> AddYazarAsync(string yazaradi) {
            return base.Channel.AddYazarAsync(yazaradi);
        }
        
        public System.Data.DataSet GetSecim(string yazaradi, string kategoriadi) {
            return base.Channel.GetSecim(yazaradi, kategoriadi);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSecimAsync(string yazaradi, string kategoriadi) {
            return base.Channel.GetSecimAsync(yazaradi, kategoriadi);
        }
        
        public System.Data.DataSet GetMakale(string baslik, string icerik) {
            return base.Channel.GetMakale(baslik, icerik);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetMakaleAsync(string baslik, string icerik) {
            return base.Channel.GetMakaleAsync(baslik, icerik);
        }
        
        public newTTSproject.HaberService1.Üye[] GetMembers() {
            return base.Channel.GetMembers();
        }
        
        public System.Threading.Tasks.Task<newTTSproject.HaberService1.Üye[]> GetMembersAsync() {
            return base.Channel.GetMembersAsync();
        }
        
        public bool MemberDogrula(string kullaniciadi, string sifre) {
            return base.Channel.MemberDogrula(kullaniciadi, sifre);
        }
        
        public System.Threading.Tasks.Task<bool> MemberDogrulaAsync(string kullaniciadi, string sifre) {
            return base.Channel.MemberDogrulaAsync(kullaniciadi, sifre);
        }
        
        public bool AddMember(string ad, string soyad, string email, string kullaniciadi, string sifre) {
            return base.Channel.AddMember(ad, soyad, email, kullaniciadi, sifre);
        }
        
        public System.Threading.Tasks.Task<bool> AddMemberAsync(string ad, string soyad, string email, string kullaniciadi, string sifre) {
            return base.Channel.AddMemberAsync(ad, soyad, email, kullaniciadi, sifre);
        }
        
        public bool AddMakale(int yazarid, int kategoriid, string baslik, string icerik) {
            return base.Channel.AddMakale(yazarid, kategoriid, baslik, icerik);
        }
        
        public System.Threading.Tasks.Task<bool> AddMakaleAsync(int yazarid, int kategoriid, string baslik, string icerik) {
            return base.Channel.AddMakaleAsync(yazarid, kategoriid, baslik, icerik);
        }
    }
}
