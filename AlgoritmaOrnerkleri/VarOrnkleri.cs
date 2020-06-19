using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmaOrnerkleri
{
    class VarOrnkleri
    {
        //Dizi içindeki a ile başlayan kelimeleri bulan kod
        public static void var()
        {
            string[] meyveler = { "Armut", "Elma", "Kivi","Muz","Üzüm","Avodako"};
            var meyve = from item in meyveler
                        where item[0] == 'A'
                        select item;

            foreach (string item in meyve)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
           
        }
    }
}
