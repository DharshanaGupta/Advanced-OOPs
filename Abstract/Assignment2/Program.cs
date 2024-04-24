using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        EEEdepartment dep1=new EEEdepartment();
        dep1.SetBookInfo("xxx","Circuit","zzzz",2010);
        dep1.DisplayInfo();

        CSEdepartment dep2=new CSEdepartment();
        dep2.SetBookInfo("yyyy","Software Testing","fffff",1998);
        dep2.DisplayInfo();
    }
}