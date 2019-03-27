using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCoinValue
{
    class Program
    {
        public static decimal CountChange(string coins)
        {
            decimal dollarAmount = 0.00M;
            string allCoins = coins.ToUpper();

            foreach (char coin in allCoins )
            {
                if(coin == 'Q')
                {
                    dollarAmount += 0.25m;
                }
                else if (coin == 'D')
                {
                    dollarAmount += 0.10m;
                }
                else if (coin == 'N')
                {
                    dollarAmount += 0.05m;
                }
                else if(coin == 'P')
                {
                    dollarAmount += 0.01m;
                }
                else
                {
                    Console.WriteLine("Incorrect Character!");
                }

            }
            return dollarAmount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type in any amount of character the reprsent coins. use Q,D,N,or P\r\nPress Enter:");
            string coin = Console.ReadLine();
            Console.WriteLine(CountChange(coin));
            Console.ReadLine();
        }
    }
}
