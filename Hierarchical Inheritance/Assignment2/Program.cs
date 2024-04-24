using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        PermanentEmployee emp1=new PermanentEmployee(20000,"permanent");
        PermanentEmployee emp2=new PermanentEmployee(30000,"Permanent");
        emp1.CalculateSalary();
        emp1.ShowSalary();
        Console.WriteLine("---------------------");
        emp2.CalculateSalary();
        emp2.ShowSalary();
        Console.WriteLine("---------------------");
        TemporaryEmployee employee1=new TemporaryEmployee(10000,"Temporary");
        TemporaryEmployee employee2=new TemporaryEmployee(15000,"Temporary");
        employee1.CalculateSalary();
        employee1.ShowSalary();
        Console.WriteLine("---------------------");
        employee2.CalculateSalary();
        employee2.ShowSalary();

    }
}