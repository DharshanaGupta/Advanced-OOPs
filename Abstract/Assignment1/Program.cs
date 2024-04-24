using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        Cylinders cylinders=new Cylinders(3,5.5,4,7);
        cylinders.CalculateArea();
        cylinders.CalculateVolume();

        Cubes cubes=new Cubes(5,3.3,3.3,8);
        cubes.CalculateArea();
        cubes.CalculateVolume();
    }
}