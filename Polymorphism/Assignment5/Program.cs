using System;
namespace Assignment5;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new EmployeeInfo("Dharshana","ramesh",1234567890,"Female");
        person1.Display();
        Console.WriteLine("-----------------");
        PersonalInfo person2=new SalaryInfo("Dharshana","Ramesh",1234567890,"Female",28,20000);
        
        person2.Display();
    }
}