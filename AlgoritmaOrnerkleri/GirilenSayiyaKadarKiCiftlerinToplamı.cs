using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class GirilenSayiyaKadarKiCiftlerinToplamı
    {
        // Dışardan girilen sayının çift rakamlarının toplamını  veren metod
        public static void method()
        {
            Console.WriteLine("Bir Sayı gir");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                }
            }
            Console.WriteLine("1'den {0}'e/a kadar ki sayıların içindeki çift rakamların toplamı : {1} ", sayi,toplam);
            Console.ReadLine();
        }
    }
}
