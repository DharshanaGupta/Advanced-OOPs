using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeMethods.EmployeeInfo s1=new EmployeeMethods.EmployeeInfo();
        s1.Display("1001","Dharshana","Female",new DateTime(2002,10,12),"123456789");
        Console.WriteLine("-----------------------------------------------------");
        s1.Update("1002","Priya","Female",new DateTime(2002,10,12),"123456789");

    }
}