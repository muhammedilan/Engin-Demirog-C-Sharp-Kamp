using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Odev1
    {
        public int Add2(int number1,int number2)
        {
            return number1 + number2;
            //return number1+number2 hata verir çünkü void bir işlem yapmanı ister bu yüzden void yerine döndürecegin tür tipini yaz
        }

        public int Add3(int number1, int number2=20) // number2 verilmezse default degeri 20 olur her zaman ensondaki parametre ye default deger vermelisin number1 e vermek istiyorsan yer değiştir diğer parametre ile yada iki parametreye de ver
        {
            return number1 + number2;
            //return number1+number2 hata verir çünkü void bir işlem yapmanı ister bu yüzden void yerine döndürecegin tür tipini yaz
        }

        public int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        public int AddOut(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // Method Overloading Method ları aynı isim farklı parametre ile kullanırsan sıkıntı olmaz
        public int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        public int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }
        public int Add5(params int[] numbers)
        {
           return numbers.Sum();
        }
        /*
          public int Add5(int number1,params int[] numbers) böyle de yapabilirsin
        {
           return numbers.Sum();
        }
        public int Add5(int number1,params int[] numbers,int number2) böyle yapamazsın params son parametre olmak zorunda
        {
           return numbers.Sum();
        }
         */

    }
}
