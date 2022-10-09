using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.LastName + " " + "Eklendi");
            Console.WriteLine("Hesap Bilgiler İçin 1'i Tuşlayınız");
            Console.WriteLine("Hesap Silmek İçin 2'yi Tuşlayınız");
            var islem = int.Parse(Console.ReadLine());
            if (islem ==1)
            {
               MusteriListele(musteri);
            } 
            else if (islem==2)
            {
               MusteriSil(musteri);
            } 
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.LastName);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.LastName + " " + "Silindi");
        }
    }
}
