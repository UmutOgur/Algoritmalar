using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmaOrnerkleri
{
    class CharIfade
    {
        public static void charislem()
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write("{0,5}", (char)i);
            }
            Console.ReadLine();
        }
    }
}
