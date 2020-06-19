using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
   public class _1den10SayilarınToplamı
    {
        
        public static void toplam()
        {
            Console.Write("Bir sayı gir : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 0; i <= sayi; i++)
            {
                toplam = toplam + i;
                
            }
            Console.WriteLine("1 den {0}'e/a  kadar ki sayıların toplamı : {1} ",sayi,toplam);
            Console.ReadLine();
        }
    }
}
