using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class Dizienbenkbulan
    {
        public static void dizbul()
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 89, 9, 454, 3543, 5657, 24332, -345, -874654 };
            int enk = dizi[0];
            int enb = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enb)
                {
                    enb = dizi[i];
                }
                else if (dizi[i] < enk)
                {
                    enk = dizi[i];
                }
            }
            Console.WriteLine("En büyük={0} ", enb);
            Console.WriteLine("En küçük =" + enk);
            Console.ReadLine();
        }
    }
}
