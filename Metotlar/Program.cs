namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Kırmızı Elma";
            urun1.Fiyat = 32.50;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Karpuz";
            urun2.Fiyat = 100;

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
            }

            //istance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); // reusability - tekrar tekrar Kullanılabilirlik (her sayfada bu fonksiyonu çalıştırabiliriz ve fonksiyonu sadece 1 kere yazarız)
            
            
            sepetManager.Ekle2("Armut","Yeşil Armut",12,4);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 22,4);
            sepetManager.Ekle2("Karpuz", "Beyaz Karpuz", 42, 4);
            /* ürünü böyle de ekleyebiliriz ama class ile yapıyoruz(Ekle Methodu) çünkü ilerde birgün şirket derse ki stok 
               adedi bilgisi de olsun üründe o zaman bütün fonksiyonu kullandıgın yeri + Ekle2 Methodunu düzenlemen gerekir
               ama class kullanırsan sadece Urun class ına gidip yeni bir özellik eklersin buna encapsulation(kapsülleme) denir
             */
        }
    }
}