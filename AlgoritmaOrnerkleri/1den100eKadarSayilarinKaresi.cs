using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class _1den100eKadarSayilarinKaresi
    {
        public static void Karesi()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("{0}'in/ın Karesi = {1}", i, i * i);
            }

            Console.ReadLine();
        }
    }
}
