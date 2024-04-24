using System;
namespace Assignment7;
class Program 
{
    public static void Main(string[] args)
    {
        Attendance month1=new Attendance(28,1,0);
        month1.Display();
        Console.WriteLine("-------------");
        Attendance month2=new Attendance(28,2,1);
        month2.Display();
        Console.WriteLine("-------------");
        Attendance month3=new Attendance(28,3,0);
        month3.Display();
    }
}