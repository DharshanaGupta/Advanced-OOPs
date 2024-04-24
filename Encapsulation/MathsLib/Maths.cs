using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        protected internal double pi=3.14;
        internal double g=9.8;

        public double PI{get{return pi;}}
        public double G{get{return g;}}

        public void CalculateWeight()
        {
            Console.WriteLine("Enter Mass Value");
            double Mass=double.Parse(Console.ReadLine());
            double weight=(double)Mass*g;
            Console.WriteLine("Weight: "+Math.Round(weight,2));
        }
    }

}