using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
  public  class ToplamaMetod
    {
        //Metod ile dışardan girilen iki sayının toplamını verelen kod.
        public static void Toplamas()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int toplam = a + b;
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
