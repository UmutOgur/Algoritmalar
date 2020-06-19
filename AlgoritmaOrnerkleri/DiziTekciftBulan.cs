using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class DiziTekciftBulan
    {
        public static void dizitekciftbulan()
        {

            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 89, 9, 454, 3543, 5657, 24332, -345, -874654 };
            Console.WriteLine("Çift sayılar");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine(dizi[i]);

                }
            }

            Console.WriteLine("Tek sayılar");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 1)
                {
                    Console.WriteLine(dizi[i]);

                }
            }


            Console.ReadLine();
        }
    }
}
