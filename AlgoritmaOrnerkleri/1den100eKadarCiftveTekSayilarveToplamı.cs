using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class _1den100eKadarCiftveTekSayilarveToplamı
    {
        public static void yuz()
        {
            int toplam = 0;
            Console.WriteLine("1 den 100 e kadar ki tek sayılar ve tek sayıların toplamı");
            for (int i = 1; i < 100; i = i + 2)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0,5}", i);
                    toplam = toplam + i;
                }
            }

            Console.WriteLine("\n Tek sayıların toplamı : " + toplam);


            Console.WriteLine("\n 1 den 100 e kadar ki tek sayılar ve tek sayıların toplamı");
            for (int i = 2; i < 100; i = i + 2)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0,5}", i);
                    toplam = toplam + i;
                }
            }
            Console.WriteLine("\n  Çift sayıların toplamı : " + toplam);
            Console.ReadLine();
        }
    }
}
