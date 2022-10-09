namespace DegerVeReferansTipler
{
    class Program {
        static void Main(string[] args) {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1); // 30 yazar çünkü sayi1 degerine sayi2 yi atadıktan sonra sayi2 nin artıp azalması birşey değiştirmez

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);/*
            Burada 999 yazdı üsttekinden farklı olmasının açıklaması: int,decimal,float,double,bool = değer tip | array,class,interface = referans tip       
            Bellek te Stack ve Heap diye 2 alan var. bir değişken tanımladıgında değer tip olanlar SADECE stack te gerçekleşir
            
            Stack şöyle çalışır : 
                                  Stack          Heap
                                sayi1=10 => burayı da 30 yapar
                                sayi2=30 => bunu 65 yapar ama sayi1 ile alakası yok burasının
           7.Satır = sayi1 in degeri eşittir sayi 2 nin degerine burada sadece deger aktarılır ve sayi2 ile olan bütün irtibat kopar. 
            
            Heap şöyle çalışır :
                                 Stack          Heap
                             101 / sayilar1 =>   101 / [10,20,30]  aralarındaki bağlantı adres le oluyor mesela sayilar 1 in adresi bellekte 101 numaralı adres 
                             102 / sayilar2 =>   102 / [100,200,300]  new = bellekte bir adres oluştur demek Heap'de           
                             
                             13. Satır'ı şöyle okumalısın sayilar1'in referans numarası sayilar2'nin referans numarasına eşittir böylece ikiside 102 numaralı aynı array'e bağlı oluyor. Heap deki 101 numara boşta kaldıgı için .NET'in garbage collector(Çöp toplayıcı)'sı gelip bellekten atıcak 101 Heap'i
                             Değer tiplerde değer i atıyorsun referans tiplerde adresi atıyorsun
                                            */

        }
    }
}