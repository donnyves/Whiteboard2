using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSpaceInSentence
{
    class Program
    {
        public static string noSpace(string sentence)   //string -> remove spaces
        {
            string nospaces = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    nospaces += sentence[i];
                }
            }
            return nospaces;

            //string nospaces = "";
            //foreach (char letter in sentence)
            //{

            //    if (letter != ' ')
            //    {
            //        string temp = char.ToString(letter);
            //        nospaces += temp;//(letter)
            //    }
            //}
            //return nospaces;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence, and the space for your string will be stripped: ");
            string input = Console.ReadLine();
            Console.WriteLine(noSpace(input));
            Console.ReadLine();
        }
    }
}
