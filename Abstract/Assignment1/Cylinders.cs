using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Cylinders:Shape
    {
        private double area;
        private double volume;
        public override double Area{get{return area;}set{area=value;}}
        public override double Volume{get{return volume;}set{volume=value;}}

        public Cylinders(double radius,double height,double width,int a):base(radius,height,width,a)
        {
            Radius=radius;
            Height=height;
            Width=width;
            A=a;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("*****Area of Cylinder*****");
            double cylinderArea=2*Math.PI*Radius*(Radius+Height);
            Console.WriteLine("Area: "+Math.Round(cylinderArea,2));
        }
        public override void CalculateVolume()
        {
            Console.WriteLine("*****Volume of Cylinder*****");
            double cylinderVolume=Math.PI*Radius*Radius*Height;
            Console.WriteLine("Volume: "+Math.Round(cylinderVolume,2));
        }
    }
}