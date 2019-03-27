using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlopeOfLine
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Line
    {
        private double yIntercept;
        private double slope;
        public Line(double yInterceptOfLine, double slopeOfLine)
        {
            yIntercept = yInterceptOfLine;
            slope = slopeOfLine;
        }
        public static void LineInterceptPoint(Line line1, Line line2)
        {
            if (line2.slope == line1.slope && line1.yIntercept != line2.yIntercept)
            {
                Console.WriteLine("Your lines are parrallel. /nThey never intercept!");
                return;
            }
            if (line2.slope == line1.slope && line1.yIntercept == line2.yIntercept)
            {
                Console.WriteLine("Your lines are the same! /nThey always intercept.");
                return;
            }
            double XInterceptOfTwoLines = (line1.yIntercept - line2.yIntercept) / (line1.slope - line2.slope);
            Console.WriteLine($"({XInterceptOfTwoLines}) is your point where your lines intercept on the x Axis");
        }
    }

}
