using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class ForDongusu
    {
        public static void forr()
        {
            int sayac = 0;
            for (int i = 10000; i >= 0; i = i - 5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }
            Console.WriteLine("\n\n Eleman sayısı :  {0}", sayac);
            Console.ReadLine();
        }
    }
}
