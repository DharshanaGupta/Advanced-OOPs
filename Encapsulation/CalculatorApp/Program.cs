using System;
namespace CalculatorApp;
using MathsLib;
class Program 
{
    public static void Main(string[] args)
    {
        Maths m=new Maths();
        Console.WriteLine("************Weight*********");
        m.CalculateWeight();
        CircleArea circle=new CircleArea();
        Console.WriteLine("********Area of Circle******");
        circle.CalculateCircleArea();
        CylinderVolume cylinder=new CylinderVolume();
        Console.WriteLine("********Volume Of Cylinder********");
        cylinder.CalculateVolume();
    }
}