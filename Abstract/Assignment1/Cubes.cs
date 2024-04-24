using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Cubes:Shape
    {
        private double area;
        private double volume;
        public override double Area{get{return area;}set{area=value;}}
        public override double Volume{get{return volume;}set{volume=value;}}

        public Cubes(double radius,double height,double width,int a):base(radius,height,width,a)
        {
            Radius=radius;
            Height=height;
            Width=width;
            A=a;
        }

        public override void CalculateArea()
        {
            Console.WriteLine("****Area of Cube*****");
            double cubeArea=6*A*A;
            Console.WriteLine("Area: "+Math.Round(cubeArea,2));
        }
        public override void CalculateVolume()
        {
            Console.WriteLine("****Volume of Cube*****");
            double cubevolume=A*A*A;
            Console.WriteLine("Volume: "+Math.Round(cubevolume,2));
        }
    }
}