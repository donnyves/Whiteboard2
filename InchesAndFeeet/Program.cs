using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class Measure
    { 
        public static int FeetToInches(int feet)
    {
        return feet * 12;
    }

    public static double InchesToFeet (int inches)
    {
        return (double) inches / 12.0;
    }


    
        static void Main(string[] args)
        {
            Console.WriteLine("Measure.Main()");

            Console.WriteLine(InchesToFeet(12) + ": Foot/Feet");
            Console.WriteLine(FeetToInches(12) + ": inch/inches");
            Console.WriteLine(InchesToFeet(6) + ": Foot/Feet");
            Console.WriteLine(FeetToInches(6) + ": inch/inches");
            Console.WriteLine(InchesToFeet(48) + ": Foot/Feet");
            Console.WriteLine(FeetToInches(48) + ": inch/inches");

            Console.ReadKey();
        }
    }
}
