using System;

namespace donguler
{
    class Program
    {

        static void Main(string[] args)
        {
            /*  int sayi=0;
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
            /*
             * int sayi = 0;
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
             Console.WriteLine(sonuc);*/
            /*              yıldızlar
                        for (int i = 1; i <=4; i++)
                        {
                            for (int j = 1; j <=i; j++)
                            {
                                Console.Write("*");

                            }


                            Console.WriteLine();
                        }

                        for (int a = 4; a >0; a--)
                        {
                            for (int f = 1; f <= a; f++)
                            {
                                Console.Write("*");

                            }


                            Console.WriteLine();
                        }
            */

            /* kare
            int en = 0;
            Console.WriteLine("En değer:");
            en = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("boy değer:");
            int boy = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=en; i++)
            {
                for (int j = 1; j <=boy; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("############" + i + "###########");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + i * j);
                }
            }
            */


        }
    }
}