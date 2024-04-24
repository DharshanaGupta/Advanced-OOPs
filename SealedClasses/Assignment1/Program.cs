using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo();
        employee.UpdateInfo("123456",100);
        employee.DisplayInfo();
    }
}