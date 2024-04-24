using System;
namespace Assignment3;
class Program 
{
    public static void Main(string[] args)
    {
        MaruthiSwift car1=new MaruthiSwift();
        car1.GetEngineType();
        car1.GetNoOfseats();
        car1.GetPrice();
        car1.GetCarType();
        car1.DisplayInfo();
        Console.WriteLine("-------------------");
        SuzukiCiaz car2=new SuzukiCiaz();
        car2.GetEngineType();
        car2.GetNoOfseats();
        car2.GetPrice();
        car2.GetCarType();
        car2.DisplayInfo();
    }
}