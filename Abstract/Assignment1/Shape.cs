using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Shape
    {
        //property 
        public abstract double Area{get;set;}
        public abstract double Volume{get;set;}
        public double Radius{get;set;}
        public double Height{get;set;}
        public double Width{get;set;}
        public int A{get;set;}

        public Shape(double radius,double height,double width,int a)
        {
            Radius=radius;
            Height=height;
            Width=width;
            A=a;
        }
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
    }
}