﻿using System;

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

            for (int i = 100; i >= 0; i-=4)
            {
                Console.WriteLine(i);
            }
        }
    }
}          
