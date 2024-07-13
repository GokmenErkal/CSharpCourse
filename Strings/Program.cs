using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Gokmen Erkal";

            int result = sentence.Length;
            object result2 = sentence.Clone();

            sentence = "My name is Ahmet";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            // Başlangıç index numarasını alır
            int result5 = sentence.IndexOf("name");
            int result6 = sentence.IndexOf(" ");
            int result7 = sentence.LastIndexOf(" ");
            string result8 = sentence.Insert(0, "Hello, ");
            string result9 = sentence.Substring(3);
            string result10 = sentence.ToLower();
            string result11 = sentence.ToUpper();
            string result12 = sentence.Replace(" ", "-");
            string result13 = sentence.Remove(2, 5);

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var c in city)
            {
                Console.WriteLine(c);
            }

            string city2 = "İstanbul";

            Console.WriteLine("{0} {1}", city, city2);
        }
    }
}
