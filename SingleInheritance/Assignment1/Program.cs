using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student1=new StudentInfo("Dharshana","Ramesh",1234567890,"sdfg@gmail.com",
        new DateTime(2022,09/12),"Female","B.Tech","IT",4);
        StudentInfo student2=new StudentInfo("xyz","xxxx",1234567890,"sdf@gmail.com",new DateTime(2002,11,03),
        "Male","BE","CSE",4);
        student1.ShowStudentInfo();
        Console.WriteLine("*******************");
        student2.ShowStudentInfo();
    }
}