using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        RegisterPerson person1=new RegisterPerson("Dharshana","Female",new DateTime(2002,11,03),1234567890,"single","Ramesh","Jayanthi","no-345,main road,chennai",1,new DateTime(2024,03,20));
        person1.ShowInfo();
        Console.WriteLine("************************");
        RegisterPerson person2=new RegisterPerson("priya","Female",new DateTime(2002,09,08),12098567890,"single","xxxx","yyyy","no-35,main road,bangalore",1,new DateTime(2024,03,28));
        person2.ShowInfo();
    }
} 