using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;
namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected double radius;
        public double Radius{get{return radius;}set{radius=value;}}
        internal double Area{get;set;}

        public double CalculateCircleArea()
        {
            Console.WriteLine("Enter radius Value: ");
            Radius=double.Parse(Console.ReadLine());
            Area=PI*Radius*Radius;
            Console.WriteLine("Circle Area: "+Area);
            return Area;
        }
    }
}