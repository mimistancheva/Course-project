﻿using System;

namespace _1
{
    class Program
    {
        /*
         Превърнете числото 2076 в двуична, осмична и шестнайсетична бройна система.
         */
        static void Main(string[] args)
        {
            int value = 2076;
            string binary = Convert.ToString(value, 2);
            string binary2 = Convert.ToString(value, 8);
            string binary3 = Convert.ToString(value, 16);
            Console.WriteLine(binary);
            Console.WriteLine(binary2);
            Console.WriteLine(binary3);

        }
    }
}
