using System.ComponentModel;
using System.Xml;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2.Gün Ödev 6 */
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


            /* 3.Gün Video */
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

            /* 3.Gün Ödev 1 */
            Odev1 odev1 = new Odev1();
            
            int number1 = 20;
            int number2 = 100;
            //var result = odev1.Add3(number1, number2);
            //Console.WriteLine(result); // 130
            //Console.WriteLine(number1); // 20 burada number1 20 olarak kalıyor çünkü int bir değer tipi dir Add fonksiyonuna number1 i değil onun değerini gönderiyorsun

            /* Ref */
            //var result = odev1.Add4(ref number1, number2);
            //Console.WriteLine(result); 130
            //Console.WriteLine(number1); 30 çünkü referans tip gibi gönderir ve number1 30 olur. başına

            /* Out */
            //int number3;
            //var result = odev1.AddOut(out number3, number2); // referans ile aynı çalışır ama referans ta değer atanmamış sayı gönderemiyoruz ama out da gönderebiliyoruz

            /* Method Overloading */
            //Console.WriteLine(odev1.Multiply(2,2,2)); // 8
            //Console.WriteLine(odev1.Multiply(2,2)); // 4

            /* Params Keyword */
            Console.WriteLine(odev1.Add5(2, 3, 4, 52, 1, 2));
        }
    }
}