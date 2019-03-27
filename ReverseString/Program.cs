using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        public static string ReverseString(string name)
        {
            string reverse = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hi, how are you?"));
            Console.ReadLine();
        }
    }
}
