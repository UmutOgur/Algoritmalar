using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class _2_likten10_lukCevirme
    {
        public static void onluk()
        {

            Console.Write("10'luk tabanına çevrilecek sayıyı giriniz : ");
            // ikilik sayinin okunması
            string ikiliksayi = Console.ReadLine();

            //uzunluğun belirlenmesi
            int n = ikiliksayi.Length;

            // her bir basamağın dizide tutulması
            int[] basamaklar = new int[n];

            //onluk karşılığı 
            int sayi = 0;
            bool kontrol = true;

            for (int i = 0; i < n; i++)
            {
                if (!(ikiliksayi[i] == '0' || ikiliksayi[i] == '1'))
                {
                    Console.WriteLine("\aHatalı Giriş ! ");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (int)(ikiliksayi[i] - '0');


            }
            // 2'lik sistemden 10'luk sistemine giriş
            if (kontrol == true)
            {
                for (int i = 0; i < n; i++)
                {
                    sayi = sayi + (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                }
                Console.WriteLine("({0}) ikilik sayı = {1}", ikiliksayi, sayi);
            }
            Console.ReadLine();

        }
    }
}
