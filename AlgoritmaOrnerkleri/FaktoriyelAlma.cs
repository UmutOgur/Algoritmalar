using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class FaktoriyelAlma
    {

        /// <summary>
        /// Dışardan girilen sayının faktöriyelini alan program
        /// </summary>          
                  
        public static void faktoriyel()

        {
            Console.Write("Faktöriyeli alınacak sayıyı giriniz : ");

            int sayi = Convert.ToInt32(Console.ReadLine());

            int farktoriyel = 1;

            for (int i = 2; i <= sayi; i++)
            {
                farktoriyel = farktoriyel * i;
            }
            Console.WriteLine("{0}!'in/ın Faktöriyeli = {1}",sayi,farktoriyel );
            Console.ReadLine();
        }
    }
}
