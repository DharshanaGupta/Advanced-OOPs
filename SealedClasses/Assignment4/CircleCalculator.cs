using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4
{
    public class CircleCalculator:Calculator
    {
        public sealed override void Area()
        {
            Console.WriteLine("Area of circle");
            Console.WriteLine("Enter Radius Value");
            int radius=int.Parse(Console.ReadLine());
            double area=(double)3.14*radius*radius;
            Console.WriteLine("Area: "+Math.Round(area,2));
        }
        public override void Volume()
        {
            
        }

    }
}