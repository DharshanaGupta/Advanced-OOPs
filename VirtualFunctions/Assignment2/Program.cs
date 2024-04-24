using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        Rectangle rect=new Rectangle();
        rect.Length=10;
        rect.Breadth=12;
        rect.Calculate();
        Console.WriteLine("************");
        Sphere sphere=new Sphere();
        sphere.Radius=15;
        sphere.Calculate();
    }
}