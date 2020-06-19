using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class If_Else
    {
        public static void İf()
        {

            Console.WriteLine("Bir kelime giriniz");
            char cr = Convert.ToChar(Console.ReadLine());

            if (char.IsUpper(cr))
            {
                Console.WriteLine("Karakter büyüktür");
            }
            else if (char.IsLower(cr))
            {
                Console.WriteLine("Karakter Küçüktür");
            }
            else if (char.IsDigit(cr))
            {
                Console.WriteLine("karakter değildir,Sayıdır.");
            }
            else
            {
                Console.WriteLine("Saçma sapan bir şey");
            }
            Console.ReadLine();
        }
    }
}
