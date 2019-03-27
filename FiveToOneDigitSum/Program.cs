using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixToOneDigitSum
{
    class Program
    {
        public static int SumOfDigits(int input)
        {
            int extract = 0;
            int sum = 0;
            while (input != 0)
            {
                extract = input % 10;//extract a digit
                sum += extract;//adding the digits from extracted number
                input = input / 10;//remained number
            }
            sum = (sum > 9) ? SumOfDigits(sum) : sum;
          
            return sum;
            //Console.WriteLine($"The sum of the digits is {sum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number,six digits or less, to get the sum of the single digit of that number:");
            int testNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumOfDigits(testNumber));
            //a sample input is 12345===>1st while loop output: 15===>2nd while loop will be 6.
            Console.ReadLine();
        }
    }
}


