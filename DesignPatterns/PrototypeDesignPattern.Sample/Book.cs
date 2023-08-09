namespace PrototypeDesignPattern.Sample
{
    public class Book : PrototypeBook
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public string YayinTarihi { get; set; }
        public int Fiyat { get; set; }

        public Book(string baslik, string yazar, int sayfaSayisi, string yayinTarihi, int fiyat)
        {
            Baslik = baslik;
            Yazar = yazar;
            SayfaSayisi = sayfaSayisi;
            YayinTarihi = yayinTarihi;
            Fiyat = fiyat;
        }

        public override Book Clone()
        {
            return MemberwiseClone() as Book;
        }
    }
}
