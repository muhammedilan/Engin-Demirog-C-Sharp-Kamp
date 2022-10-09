using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Müşteri Eklemek için 0");
            Console.WriteLine("Müşterileri Listelemek İçin 1");
            Console.WriteLine("Müşterileri Silmek İçin 2");

            var islem = int.Parse(Console.ReadLine());

            Musteri musteri = new Musteri();
            MusteriManager musteriManager = new MusteriManager();   

            if(islem == 0)
            {
                Console.WriteLine("Adınızı ve Soyadınızı Giriniz Örnek : Muhammed İlan");
                string isim = Console.ReadLine();
                if(isim.Split(" ").Length == 2)
                {
                    string firstName = isim.Split(" ")[0];
                    string lastName= isim.Split(" ")[1];
                    musteri.FirstName = firstName;
                    musteri.LastName = lastName;
                    musteriManager.MusteriEkle(musteri);
                } else
                {
                    Console.WriteLine("Hatalı İsim Girişi Örnege İyi Bakın");
                }
            } else if (islem == 1)
            {
                musteri.FirstName = "Kullanıcı Adı";
                musteri.LastName = "Kullanıcı Soyadı";
                musteriManager.MusteriListele(musteri); // veritabanı olmadıgı için burada üstte eklenen müşteri yi alıp listeleyemiyorum ama müşteri ekleme de hesap bilgilerini gösterebiliyorum.
            }
            else if (islem == 2)
            {
                musteri.FirstName = "Kullanıcı Adı";
                musteri.LastName = "Kullanıcı Soyadı";
                musteriManager.MusteriSil(musteri);
            }
            Console.ReadLine();
        }
    }
}