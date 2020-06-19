using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    public class AsalSayi
    {
        public static void Asal()
        {
            int sayac = 0;
            Console.Write("Sayıyı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi <= 1)
            {
                Console.WriteLine("En küçük asal sayı 2 dir.");
            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                    }
                }

                if (sayac == 0)
                {
                    Console.WriteLine("Girilen Sayı Asal={0}", sayi);
                }
                else
                {
                    Console.WriteLine("Girilen Sayı Asal Değil={0}", sayi);
                }
            }

           
            Console.ReadKey();
        }
    }
}
