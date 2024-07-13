using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Console.WriteLine(Add2(1, 2));

            //int number1 = 20;
            //int number2 = 100;
            //var result = Add3(ref number1, number2);

            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2, 4, 2));

            //Console.WriteLine(result);
            //Console.WriteLine(number1);

            Console.WriteLine(Add4(1,2,3,4,5,6,7,8,9,10));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int num1, int num2 = 30)
        {
            var result = num1 + num2;
            return result;
        }

        static int Add3(ref int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

        static int Multiply(int num1, int num2)
        {
            var result = num1 * num2;
            return result;
        }

        static int Multiply(int num1, int num2, int num3)
        {
            var result = num1 * num2 * num3;
            return result;
        }

    }
}
