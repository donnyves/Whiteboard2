using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrime
{
    class SumOfPrimeProgram
    {
        public static bool IsPrime(int num)
        {
            if (num == 0) return false;
            if (num == 1) return false;

            int i = 2;
            while (i < num) 
            {
               if (num % i == 0) return false;
                           
               i++;
            }
            return true; 
        }
        //
        public static int PrimeSums(int checknum)
        {
            int sumPrime;
            sumPrime = 0;
           
            for (int i = 0; i <= checknum ; i++)
            {
                //IsPrime() is called to evalute if the number prime or not prime.
                //If the number is prime, then the sum of primes will be counted.
                
                if (IsPrime(i))
                {
                    sumPrime += i;
                }
            }
            return sumPrime;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Type in a number, to see if it's prime: ");
            int primeInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your number is: {IsPrime (primeInput)}");

            Console.WriteLine("Type in a number, to get the sum of primes for that number: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"The sum of all primes for your number is: {PrimeSums(userInput)}");
            Console.ReadLine();
        }
    }
}
