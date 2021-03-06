//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication12.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HEALTHYFITEntities : DbContext
    {
        public HEALTHYFITEntities()
            : base("name=HEALTHYFITEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<Kurs> Kurs { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MaasDekont> MaasDekont { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Antrenor> Antrenor { get; set; }
        public virtual DbSet<DekontListele> DekontListele { get; set; }
        public virtual DbSet<FaturaListele> FaturaListele { get; set; }
        public virtual DbSet<PersonelList> PersonelList { get; set; }
        public virtual DbSet<SalonKurslariListele> SalonKurslariListele { get; set; }
        public virtual DbSet<SalonListele> SalonListele { get; set; }
    
        public virtual int AntrenorAlanKayitlama(Nullable<short> personelId, Nullable<byte> alan1, Nullable<byte> alan2, Nullable<byte> alan3)
        {
            var personelIdParameter = personelId.HasValue ?
                new ObjectParameter("PersonelId", personelId) :
                new ObjectParameter("PersonelId", typeof(short));
    
            var alan1Parameter = alan1.HasValue ?
                new ObjectParameter("Alan1", alan1) :
                new ObjectParameter("Alan1", typeof(byte));
    
            var alan2Parameter = alan2.HasValue ?
                new ObjectParameter("Alan2", alan2) :
                new ObjectParameter("Alan2", typeof(byte));
    
            var alan3Parameter = alan3.HasValue ?
                new ObjectParameter("Alan3", alan3) :
                new ObjectParameter("Alan3", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AntrenorAlanKayitlama", personelIdParameter, alan1Parameter, alan2Parameter, alan3Parameter);
        }
    
        public virtual int AntrenorRandevuAl(Nullable<short> salonId, Nullable<short> personelId, Nullable<short> musteriId, Nullable<System.DateTime> tarihSaat)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            var personelIdParameter = personelId.HasValue ?
                new ObjectParameter("PersonelId", personelId) :
                new ObjectParameter("PersonelId", typeof(short));
    
            var musteriIdParameter = musteriId.HasValue ?
                new ObjectParameter("MusteriId", musteriId) :
                new ObjectParameter("MusteriId", typeof(short));
    
            var tarihSaatParameter = tarihSaat.HasValue ?
                new ObjectParameter("tarihSaat", tarihSaat) :
                new ObjectParameter("tarihSaat", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AntrenorRandevuAl", salonIdParameter, personelIdParameter, musteriIdParameter, tarihSaatParameter);
        }
    
        public virtual int DiyetisyenRandevuAl(Nullable<short> salonId, Nullable<short> personelId, Nullable<short> musteriId, Nullable<System.DateTime> tarihSaat)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            var personelIdParameter = personelId.HasValue ?
                new ObjectParameter("PersonelId", personelId) :
                new ObjectParameter("PersonelId", typeof(short));
    
            var musteriIdParameter = musteriId.HasValue ?
                new ObjectParameter("MusteriId", musteriId) :
                new ObjectParameter("MusteriId", typeof(short));
    
            var tarihSaatParameter = tarihSaat.HasValue ?
                new ObjectParameter("tarihSaat", tarihSaat) :
                new ObjectParameter("tarihSaat", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiyetisyenRandevuAl", salonIdParameter, personelIdParameter, musteriIdParameter, tarihSaatParameter);
        }
    
        public virtual int FaturaEkleme(Nullable<short> salonId, Nullable<short> musteriId, Nullable<decimal> miktar, Nullable<System.DateTime> tarih)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            var musteriIdParameter = musteriId.HasValue ?
                new ObjectParameter("MusteriId", musteriId) :
                new ObjectParameter("MusteriId", typeof(short));
    
            var miktarParameter = miktar.HasValue ?
                new ObjectParameter("Miktar", miktar) :
                new ObjectParameter("Miktar", typeof(decimal));
    
            var tarihParameter = tarih.HasValue ?
                new ObjectParameter("Tarih", tarih) :
                new ObjectParameter("Tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FaturaEkleme", salonIdParameter, musteriIdParameter, miktarParameter, tarihParameter);
        }
    
        public virtual int KullaniciSil(Nullable<long> tC)
        {
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KullaniciSil", tCParameter);
        }
    
        public virtual int MaasDekontEkleme(Nullable<short> salonId, Nullable<short> personelId, Nullable<bool> personelTuru, Nullable<decimal> miktar, Nullable<System.DateTime> tarih)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            var personelIdParameter = personelId.HasValue ?
                new ObjectParameter("PersonelId", personelId) :
                new ObjectParameter("PersonelId", typeof(short));
    
            var personelTuruParameter = personelTuru.HasValue ?
                new ObjectParameter("PersonelTuru", personelTuru) :
                new ObjectParameter("PersonelTuru", typeof(bool));
    
            var miktarParameter = miktar.HasValue ?
                new ObjectParameter("Miktar", miktar) :
                new ObjectParameter("Miktar", typeof(decimal));
    
            var tarihParameter = tarih.HasValue ?
                new ObjectParameter("Tarih", tarih) :
                new ObjectParameter("Tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MaasDekontEkleme", salonIdParameter, personelIdParameter, personelTuruParameter, miktarParameter, tarihParameter);
        }
    
        public virtual ObjectResult<MusteriAntrenorRandevuListele_Result> MusteriAntrenorRandevuListele(Nullable<short> musteriId)
        {
            var musteriIdParameter = musteriId.HasValue ?
                new ObjectParameter("MusteriId", musteriId) :
                new ObjectParameter("MusteriId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusteriAntrenorRandevuListele_Result>("MusteriAntrenorRandevuListele", musteriIdParameter);
        }
    
        public virtual int MusteriDetayGuncelleme(Nullable<long> tC, Nullable<byte> boy, Nullable<byte> kilo)
        {
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(long));
    
            var boyParameter = boy.HasValue ?
                new ObjectParameter("Boy", boy) :
                new ObjectParameter("Boy", typeof(byte));
    
            var kiloParameter = kilo.HasValue ?
                new ObjectParameter("Kilo", kilo) :
                new ObjectParameter("Kilo", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MusteriDetayGuncelleme", tCParameter, boyParameter, kiloParameter);
        }
    
        public virtual int MusteriDetayKayitlama(Nullable<long> tC, Nullable<byte> boy, Nullable<byte> kilo, Nullable<bool> cinsiyet, Nullable<System.DateTime> dogumTarih)
        {
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(long));
    
            var boyParameter = boy.HasValue ?
                new ObjectParameter("Boy", boy) :
                new ObjectParameter("Boy", typeof(byte));
    
            var kiloParameter = kilo.HasValue ?
                new ObjectParameter("Kilo", kilo) :
                new ObjectParameter("Kilo", typeof(byte));
    
            var cinsiyetParameter = cinsiyet.HasValue ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(bool));
    
            var dogumTarihParameter = dogumTarih.HasValue ?
                new ObjectParameter("DogumTarih", dogumTarih) :
                new ObjectParameter("DogumTarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MusteriDetayKayitlama", tCParameter, boyParameter, kiloParameter, cinsiyetParameter, dogumTarihParameter);
        }
    
        public virtual ObjectResult<MusteriDiyetisyenRandevuListele_Result> MusteriDiyetisyenRandevuListele(Nullable<short> musteriId)
        {
            var musteriIdParameter = musteriId.HasValue ?
                new ObjectParameter("MusteriId", musteriId) :
                new ObjectParameter("MusteriId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusteriDiyetisyenRandevuListele_Result>("MusteriDiyetisyenRandevuListele", musteriIdParameter);
        }
    
        public virtual ObjectResult<MusteriFaturasiListele_Result> MusteriFaturasiListele(Nullable<short> musteriId)
        {
            var musteriIdParameter = musteriId.HasValue ?
                new ObjectParameter("MusteriId", musteriId) :
                new ObjectParameter("MusteriId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusteriFaturasiListele_Result>("MusteriFaturasiListele", musteriIdParameter);
        }
    
        public virtual int MusteriKullaniciKayitlama(Nullable<long> tC, string kullaniciAd, string sifre, string ad, string soyad, Nullable<short> salonId, Nullable<byte> boy, Nullable<byte> kilo, Nullable<bool> cinsiyet, Nullable<System.DateTime> dogumTarih)
        {
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(long));
    
            var kullaniciAdParameter = kullaniciAd != null ?
                new ObjectParameter("KullaniciAd", kullaniciAd) :
                new ObjectParameter("KullaniciAd", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("Sifre", sifre) :
                new ObjectParameter("Sifre", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("Ad", ad) :
                new ObjectParameter("Ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("Soyad", soyad) :
                new ObjectParameter("Soyad", typeof(string));
    
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            var boyParameter = boy.HasValue ?
                new ObjectParameter("Boy", boy) :
                new ObjectParameter("Boy", typeof(byte));
    
            var kiloParameter = kilo.HasValue ?
                new ObjectParameter("Kilo", kilo) :
                new ObjectParameter("Kilo", typeof(byte));
    
            var cinsiyetParameter = cinsiyet.HasValue ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(bool));
    
            var dogumTarihParameter = dogumTarih.HasValue ?
                new ObjectParameter("DogumTarih", dogumTarih) :
                new ObjectParameter("DogumTarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MusteriKullaniciKayitlama", tCParameter, kullaniciAdParameter, sifreParameter, adParameter, soyadParameter, salonIdParameter, boyParameter, kiloParameter, cinsiyetParameter, dogumTarihParameter);
        }
    
        public virtual ObjectResult<MusteriRandevuListele_Result> MusteriRandevuListele(Nullable<short> musteriId)
        {
            var musteriIdParameter = musteriId.HasValue ?
                new ObjectParameter("MusteriId", musteriId) :
                new ObjectParameter("MusteriId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusteriRandevuListele_Result>("MusteriRandevuListele", musteriIdParameter);
        }
    
        public virtual ObjectResult<PersonelDekontListele_Result> PersonelDekontListele(Nullable<short> personelId)
        {
            var personelIdParameter = personelId.HasValue ?
                new ObjectParameter("PersonelId", personelId) :
                new ObjectParameter("PersonelId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PersonelDekontListele_Result>("PersonelDekontListele", personelIdParameter);
        }
    
        public virtual int PersonelDetayKayitlama(Nullable<long> tC, Nullable<long> iBAN, Nullable<long> sGKNo, Nullable<bool> personelTur)
        {
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(long));
    
            var iBANParameter = iBAN.HasValue ?
                new ObjectParameter("IBAN", iBAN) :
                new ObjectParameter("IBAN", typeof(long));
    
            var sGKNoParameter = sGKNo.HasValue ?
                new ObjectParameter("SGKNo", sGKNo) :
                new ObjectParameter("SGKNo", typeof(long));
    
            var personelTurParameter = personelTur.HasValue ?
                new ObjectParameter("PersonelTur", personelTur) :
                new ObjectParameter("PersonelTur", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PersonelDetayKayitlama", tCParameter, iBANParameter, sGKNoParameter, personelTurParameter);
        }
    
        public virtual int PersonelKullaniciKayitlama(Nullable<long> tC, string kullaniciAd, string sifre, string ad, string soyad, Nullable<short> salonId, Nullable<long> iBAN, Nullable<long> sGKNo, Nullable<bool> personelTur)
        {
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(long));
    
            var kullaniciAdParameter = kullaniciAd != null ?
                new ObjectParameter("KullaniciAd", kullaniciAd) :
                new ObjectParameter("KullaniciAd", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("Sifre", sifre) :
                new ObjectParameter("Sifre", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("Ad", ad) :
                new ObjectParameter("Ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("Soyad", soyad) :
                new ObjectParameter("Soyad", typeof(string));
    
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            var iBANParameter = iBAN.HasValue ?
                new ObjectParameter("IBAN", iBAN) :
                new ObjectParameter("IBAN", typeof(long));
    
            var sGKNoParameter = sGKNo.HasValue ?
                new ObjectParameter("SGKNo", sGKNo) :
                new ObjectParameter("SGKNo", typeof(long));
    
            var personelTurParameter = personelTur.HasValue ?
                new ObjectParameter("PersonelTur", personelTur) :
                new ObjectParameter("PersonelTur", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PersonelKullaniciKayitlama", tCParameter, kullaniciAdParameter, sifreParameter, adParameter, soyadParameter, salonIdParameter, iBANParameter, sGKNoParameter, personelTurParameter);
        }
    
        public virtual ObjectResult<PersonelRandevuListele_Result> PersonelRandevuListele(Nullable<short> personelId)
        {
            var personelIdParameter = personelId.HasValue ?
                new ObjectParameter("PersonelId", personelId) :
                new ObjectParameter("PersonelId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PersonelRandevuListele_Result>("PersonelRandevuListele", personelIdParameter);
        }
    
        public virtual int RandevuSil(Nullable<int> randevuId)
        {
            var randevuIdParameter = randevuId.HasValue ?
                new ObjectParameter("RandevuId", randevuId) :
                new ObjectParameter("RandevuId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RandevuSil", randevuIdParameter);
        }
    
        public virtual ObjectResult<SalonAntrenorListele_Result> SalonAntrenorListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonAntrenorListele_Result>("SalonAntrenorListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SalonAntrenorRandevuListele_Result> SalonAntrenorRandevuListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonAntrenorRandevuListele_Result>("SalonAntrenorRandevuListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SalonDiyetisyenListele_Result> SalonDiyetisyenListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonDiyetisyenListele_Result>("SalonDiyetisyenListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SalonDiyetisyenRandevuListele_Result> SalonDiyetisyenRandevuListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonDiyetisyenRandevuListele_Result>("SalonDiyetisyenRandevuListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SalonFaturaListele_Result> SalonFaturaListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonFaturaListele_Result>("SalonFaturaListele", salonIdParameter);
        }
    
        public virtual ObjectResult<string> SalonKursListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SalonKursListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SalonMaasDekontListele_Result> SalonMaasDekontListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonMaasDekontListele_Result>("SalonMaasDekontListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SalonMusteriListele_Result> SalonMusteriListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonMusteriListele_Result>("SalonMusteriListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SalonRandevuListele_Result> SalonRandevuListele(Nullable<short> salonId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalonRandevuListele_Result>("SalonRandevuListele", salonIdParameter);
        }
    
        public virtual ObjectResult<SehirKursListele_Result> SehirKursListele(Nullable<byte> plakaKod)
        {
            var plakaKodParameter = plakaKod.HasValue ?
                new ObjectParameter("PlakaKod", plakaKod) :
                new ObjectParameter("PlakaKod", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SehirKursListele_Result>("SehirKursListele", plakaKodParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int YoneticiKullaniciKayitlama(Nullable<long> tC, string kullaniciAd, string sifre, string ad, string soyad, Nullable<short> salonId)
        {
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(long));
    
            var kullaniciAdParameter = kullaniciAd != null ?
                new ObjectParameter("KullaniciAd", kullaniciAd) :
                new ObjectParameter("KullaniciAd", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("Sifre", sifre) :
                new ObjectParameter("Sifre", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("Ad", ad) :
                new ObjectParameter("Ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("Soyad", soyad) :
                new ObjectParameter("Soyad", typeof(string));
    
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("YoneticiKullaniciKayitlama", tCParameter, kullaniciAdParameter, sifreParameter, adParameter, soyadParameter, salonIdParameter);
        }
    
        public virtual int YoneticiKursEkleme(string kursAd)
        {
            var kursAdParameter = kursAd != null ?
                new ObjectParameter("KursAd", kursAd) :
                new ObjectParameter("KursAd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("YoneticiKursEkleme", kursAdParameter);
        }
    
        public virtual int YoneticiSalonKursEkleme(Nullable<short> salonId, Nullable<byte> kursId)
        {
            var salonIdParameter = salonId.HasValue ?
                new ObjectParameter("SalonId", salonId) :
                new ObjectParameter("SalonId", typeof(short));
    
            var kursIdParameter = kursId.HasValue ?
                new ObjectParameter("KursId", kursId) :
                new ObjectParameter("KursId", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("YoneticiSalonKursEkleme", salonIdParameter, kursIdParameter);
        }
    }
}
