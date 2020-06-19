using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class SesliHarfBulma
    {
        public static string seslibul(string ifade)
        {
            
            int sesliharf = 0;
            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'I' || ifade[i] == 'İ' ||
                    ifade[i] == 'ı' || ifade[i] == 'i' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö')
                    sesliharf++;
            }

            Console.WriteLine("\nGirilen metin ifadesinde " + "" + sesliharf + " " + "adet sesli harf vardır.");
            Console.WriteLine("Bunlar : " + ifade);
            Console.ReadLine();
            return ifade;
        }
    }
}
