using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Program
    {
        public static string NoSpaceFor(string sentenceFor)
        {
            string nospaces = "";

            foreach (char letter in sentenceFor)
            {

                if (letter != ' ')
                {
                    string temp = char.ToString(letter);
                    nospaces += temp;
                }
            }
            return nospaces;
        }
        public static string noSpace(string sentence)   //string -> remove spaces
        {
            string nospace = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    nospace += sentence[i];
                }
            }
            return nospace;       
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NoSpaceFor("The orange goat fights"));
            Console.WriteLine(noSpace("the Yellow bird Eats"));             
            Console.ReadLine();
        }
    }
}

