using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class DaireninCapi
    {
        public static void Daire()
        {
            const double pi = 3.14;
            Console.Write("Yarı Çap giriniz : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bir açı giriniz : ");
            double açi = Convert.ToDouble(Console.ReadLine());

            double alanhesapla;

            alanhesapla = pi * r * r * açi / 360;

            Console.WriteLine("Yarı Çapı" + " " + r + " ve Açısı" + " " + açi + " " + "olan bir Dairinin Alanı :" + " " + alanhesapla + " 'dir/dur.");
            Console.ReadLine();
        }
    }
}
