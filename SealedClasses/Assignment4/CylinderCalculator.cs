using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Assignment4
{
    public class CylinderCalculator:CircleCalculator
    {
        public override void Area()//can't override the Area() method because it is sealed
        {
            Console.WriteLine("Area of circle");
            Console.WriteLine("Enter Radius Value");
            
            int radius=int.Parse(Console.ReadLine());
            Console.WriteLine("enter Height");
            int height=int.Parse(Console.ReadLine());
            double area=(double)3.14*radius*radius*height;
            Console.WriteLine("Area: "+Math.Round(area,2));
        }
        public override void Volume()
        {
            
        }
        
    }
}