using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPrime
{
    class WhilePrime
    {
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;// not neccessary

            int i = 2;

            while (i < num)

            {
                if (num % i == 0) return false;
                i++;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tPrime.Main()");

            //The for loop prints out whether the numbers up to 20.
            //The if less statement prints out whether is prime or not prime.

            for (int i = 0; i <= 20; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine($"{i} is prime!");
                }
                else
                {
                    Console.WriteLine($"{i} is not prime a prime number!");
                }
                Console.ReadKey();
            }
        }
    }
}
