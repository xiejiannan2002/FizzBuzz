using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintFizzBuzz();
            Console.ReadLine();
        }

        public static string GetFizzBuzz(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return number.ToString();
        }

        public static void PrintFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetFizzBuzz(i));
            }
        }
    }
}
