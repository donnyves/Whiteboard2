using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Program
    {
        public static string noSpace(string sentence)   //string -> remove spaces
        {
            string nospaces = " ";
            /*for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    nospaces[i] += sentence[i];
                }
            }
            return nospaces;
            */

            foreach(char letter in sentence)
            {

                if (letter != ' ')
                {
                    

                    string temp = char.ToString(letter);
                    nospaces += temp;
                }
            }
            return nospaces; 
        }

        public static string ReverseString(string name)
        {
            string reverse = "";

            for (int i = name.Length-1; i >= 0; i--)
            {
                reverse += name[i];
            }

            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(noSpace("the Yellow bird Eats"));
            Console.WriteLine(ReverseString("hello"));

            Console.ReadLine();
        }
    }
}
