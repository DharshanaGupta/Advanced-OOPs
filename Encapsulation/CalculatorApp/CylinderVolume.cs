using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;
namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
    {
        private double height;
        public double Height{get{return height;}set{height=value;}}


        public void CalculateVolume()
        {
            double area=CalculateCircleArea();
            Console.WriteLine("Enter Height value");
            Height=double.Parse(Console.ReadLine());
            double volume=area*Height;
            Console.WriteLine("Cylinder volume: "+volume);
        }

    }
}