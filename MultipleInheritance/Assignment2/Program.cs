using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        ShiftDezire car1=new ShiftDezire("pertrol",6,"Black",20,150,"Shift","Desire",1234,0987);
        Console.WriteLine("----------------------------");
        car1.ShowDetails();
        Console.WriteLine("----------------------------");
        ShiftDezire car2=new ShiftDezire("Diesel",4,"Blue",18,100,"Shift","Desire",12974,7653);
        car2.ShowDetails();
        Console.WriteLine("----------------------------");
        Eco car3=new Eco("cng",6,"Black",25,180,"Eco","Eco23",4567,0987);
        car3.ShowDetails();
        Console.WriteLine("----------------------------");
        Eco car4=new Eco("Petrol",4,"Red",15,100,"Eco","Eco23",4098,1234);
        car4.ShowDetails();


    }
}
