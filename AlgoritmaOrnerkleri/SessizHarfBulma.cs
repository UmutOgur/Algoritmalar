using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class SessizHarfBulma
    {

        public static string sessizHarfBul(string ifade)
        {
            int sesli = 0;
            int sessizharf = 0;


            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == 'b' || ifade[i] == 'B' ||
                    ifade[i] == 'c' || ifade[i] == 'C' ||
                    ifade[i] == 'ç' || ifade[i] == 'Ç' ||
                    ifade[i] == 'd' || ifade[i] == 'D' ||
                    ifade[i] == 'g' || ifade[i] == 'G' ||
                    ifade[i] == 'ğ' || ifade[i] == 'Ğ' ||
                    ifade[i] == 'j' || ifade[i] == 'J' ||
                    ifade[i] == 'h' || ifade[i] == 'H' ||
                    ifade[i] == 'k' || ifade[i] == 'K' ||
                    ifade[i] == 'l' || ifade[i] == 'L' ||
                    ifade[i] == 'm' || ifade[i] == 'M' ||
                    ifade[i] == 'n' || ifade[i] == 'N' ||
                    ifade[i] == 'r' || ifade[i] == 'R' ||
                    ifade[i] == 'p' || ifade[i] == 'P' ||
                    ifade[i] == 's' || ifade[i] == 'S' ||
                    ifade[i] == 'ş' || ifade[i] == 'Ş' ||
                    ifade[i] == 't' || ifade[i] == 'T' ||
                    ifade[i] == 'v' || ifade[i] == 'V' ||
                    ifade[i] == 'z' || ifade[i] == 'Z' ||
                    ifade[i] == 'y' || ifade[i] == 'Y' ||
                    ifade[i] == 'f' || ifade[i] == 'F')
                {
                    sessizharf++;

                }
                else if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'I' || ifade[i] == 'İ' ||
                    ifade[i] == 'ı' || ifade[i] == 'i' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö')
                {
                    sesli++;
                }

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\nGirilen metin ifadesinde " + "" + sessizharf + " " + "adet sessiz harf vardır.");
            Console.WriteLine("\nGirilen metin ifadesinde " + "" + sesli + " " + "adet sesli harf vardır.");

            Console.ReadLine();
            return ifade;
        }
    }
}
