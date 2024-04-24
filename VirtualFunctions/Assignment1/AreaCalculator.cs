using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class AreaCalculator
    {
        //property
        public int Radius{get;set;}

        public virtual void Calculate()
        {
            double area=(double)3.14*Radius*Radius;
            Console.WriteLine("Area: "+area);
        }
    }
}