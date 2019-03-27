using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdd2
{
 

    public class SumOfOddsClass
    {
        public static int SumofOdd(int num)
        {

            int SumOfOdd = 0;

            for (int i = 0; i <= num; i++)
            {

                if (i % 2 == 1)
                {
                    SumOfOdd += i;
                }
            }
            return SumOfOdd;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumofOdd(15));
            Console.ReadLine();
        }
    }
}
