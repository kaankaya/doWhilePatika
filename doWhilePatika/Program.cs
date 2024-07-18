using System;

namespace doPatika
{
    class Program
    {
        static void Main(string[] args) 
        {

            /*
             Aşağıdaki örnek hem while hem do while ile yapılmıştır.Arasındaki fark şudur
            While döngüsü koşul olduğu sürece gerçekleşir ,koşul olmadan gerçekleşme durumu yoktur
            ama do while döngüsü ise 1 kere de olsa çalışır ama while da koşul sağlanmadan çalışmaz
             */
            //hedef sayı ve sayaç için değişken tanımlama
            int limit = 0;
            int counter = 0;
            //kullanıcı veri girişi alma
            Console.WriteLine("Döngünün tekrar etmesini istediğiz Sayıyı Yazınız");
            limit = Convert.ToInt32(Console.ReadLine());
            //girilen sayının negatif olup olmadıgının kontrolu
           if (limit >= 0)
            {
                //pozitif ise işlem
                while (counter <= limit)
                {
                    Console.WriteLine("Ben bir Patikalıyım");
                    counter++;
                }
            }
            else
            {
                //negatif ise işlem
                while (counter >= limit)
                {
                    Console.WriteLine("Ben bir Patikalıyım");
                    counter--;
                }
            }//end if

            //Do-While Kullanarak Yapımı
            //hedef sayı ve sayaç için değişken tanımlama
            int limite = 0;
            int countere = 0;

            if (limite >= 0)
            {
                //pozitif ise işlem
                do
                {
                    Console.WriteLine("Ben Bir Patika'lıyım");
                    countere++;
                } while (countere <= limite);
            }
            else
            {
                //negatif ise işlem
                do
                {
                    Console.WriteLine("Ben Bir Patika'lıyım");
                    countere--;
                } while (countere >= limite);
            }//end if
        }
    }
}