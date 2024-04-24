using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Sphere:Dimension
    {
        public int Radius{get;set;}

        public override void Calculate()
        {
            double area=4*3.14*Radius*Radius;
            Console.WriteLine("Area: "+area);
        }

    }
}