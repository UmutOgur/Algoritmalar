using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class CarpimTablosu
    {
        public  static void Carpim()
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n\n --------------------- \n\n");
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine("{0,5} \t * {1,5} : {2,5} ", i, a, i * a);
                }

                Console.WriteLine("\n\n --------------------- \n\n");
            }

            Console.ReadLine();
        }
    }
}
