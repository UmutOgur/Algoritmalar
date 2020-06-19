using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class stringDesenolusturma
    {
        public static void desen()
        {
            for (int i = 1; i < 10; i++)
            {

                string desen = new string('*', i);
                Console.Write("\n{0,5}", desen);
            }

            Console.ReadLine();
        }
    }
}
