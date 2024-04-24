using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Dimension
    {
        //property
        public int Value1{get;set;}
        public int Value2{get;set;}

        public virtual void Calculate()
        {
            double area=Value1*Value2;
            Console.WriteLine("Area: "+area);
        }
    }
}