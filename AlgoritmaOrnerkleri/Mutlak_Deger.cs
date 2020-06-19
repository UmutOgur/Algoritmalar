using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class Mutlak_Deger
    {

        public static int mutlak(int n)
        {
            //Console.WriteLine("Bir sayı gir");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Girilen sayının mutlak değeri = {0} ", n);
            //Console.ReadLine();

            if (n > 0)
            {
                return n;
            }

            else if (n < 0)
            {
                return -1 * n;
            }
            else
            {
                return 0;
            }

        }
    }
}
