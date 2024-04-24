using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        Dog dog=new Dog("Pomerian","Grassland","meal");
        Duck duck=new Duck("Duck","Water","Seeds&Insects");
        dog.DisplayInfo();
        Console.WriteLine("****************");
        duck.DisplayInfo();
    }
}