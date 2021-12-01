using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     int sayi=0;
                int i;
                for ( i = 1; i < 101; i++)
                {

                    if (i%2==0)
                    {
                         sayi = sayi + i;
                    }
                }
                Console.WriteLine($"{sayi}");*/

            /* for (int i = 100; i >= 0; i-=4)
             {
                 Console.WriteLine(i);
             }*/
            /*https://www.kodbloklari.com/csharp-faktoriyel-hesaplama/
             * int fak = 1;
             Console.WriteLine("bir sayı giriniz");
             int enter = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i<=enter; i++)
             {
                 fak*= i;
             }
             Console.WriteLine($"Faktoriyel {fak}");*/
            int sayi = 0;
            int son = 0;
            Console.WriteLine("Ortalamasını almak istediğiniz sayı adeti:");
            int adet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine($"{i}.Sayı Giriniz");
                 sayi = Convert.ToInt32(Console.ReadLine());
                son+=  sayi;
            }
          int sonuc= son / adet;
            Console.WriteLine(sonuc);
        }
    }
}          
