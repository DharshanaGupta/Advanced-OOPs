using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle:Dimension
    {
        public int Length{get;set;}
        public int Breadth{get;set;}

        public override void Calculate()
        {
            double area=Length*Breadth;
            Console.WriteLine("Area: "+area);
        }

    }
}