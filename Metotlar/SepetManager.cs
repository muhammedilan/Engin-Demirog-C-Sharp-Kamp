using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi);
            // Console.WriteLine("Tebrikler Sepete Eklendi"); böyle yapmak istesem üstekini siler bunu yazarım ama her sayfaya ayrı ayrı yazarsam her sayfa ile uğraşmam gerek
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdeti)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi"+urunAdi);
        }
    }
}
