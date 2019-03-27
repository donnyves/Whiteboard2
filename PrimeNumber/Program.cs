using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberForLoop
{
    

    class Program
    {
        public static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(9));
          

            Console.ReadLine();
        }
    }
}
