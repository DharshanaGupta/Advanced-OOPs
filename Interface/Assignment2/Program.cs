using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Dharshana","Ramesh",123456789);
        student.Display();
        Console.WriteLine("****************");
        EmployeeInfo employee = new EmployeeInfo("Dharshana","Ramesh");
        employee.Display();
    }
}