﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Values Types
            // Consolo.WriteLine("Hello World");

            char character = 'a';
            bool condition = false;
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            double number5 = 10.4;
            decimal number6 = 10.3m;
            var number7 = 10;
            number7 = 'A';
            //number7 = "a";

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Character is: {0}", (int)character);

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday  
    }
}
