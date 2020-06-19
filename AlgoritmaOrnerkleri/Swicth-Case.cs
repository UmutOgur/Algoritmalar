using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class Swicth_Case
    {
        public enum Renkler { Sarı, Turucu, Mavi, Pembe, Mor, Kırmızı, Turkuaz }
        public static void Swicth()
        {
            Renkler rastgele = (Renkler)(new Random()).Next(0,6);

            switch (rastgele)
            {
                case Renkler.Sarı:
                    Console.WriteLine("Rastgele renk : " + " " + Renkler.Sarı);
                    break;
                case Renkler.Turucu:
                    Console.WriteLine("Rastgele renk :" +" "+ Renkler.Turucu);
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("Rastgele renk :" +" "+ Renkler.Mavi);
                    break;
                case Renkler.Pembe:
                    Console.WriteLine("Rastgele renk :" +" "+ Renkler.Pembe);
                    break;
                case Renkler.Mor:
                    Console.WriteLine("Rastgele renk :" +" "+ Renkler.Mor);
                    break;
                case Renkler.Kırmızı:
                    Console.WriteLine("Rastgele renk :" +" "+ Renkler.Kırmızı);
                    break;
                case Renkler.Turkuaz:
                    Console.WriteLine("Rastgele renk :" +" "+ Renkler.Turkuaz);
                    break;
                default:
                    Console.WriteLine("Renk yok");
                    break;
            }
            Console.ReadLine();

        }
    }
}
