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
            string nospaces = " ";
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] != ' ')
            //    {

            //        nospaces[i] += sentence[i];
            //    }
            //}
            //return nospaces;


            foreach (char letter in sentence)
            {

                if (letter != ' ')
                {
                    string temp = char.ToString(letter);
                    nospaces += temp;//(letter)
                }
            }
            return nospaces;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(noSpace("Hi how are you."));
            Console.ReadLine();
        }
    }
}
