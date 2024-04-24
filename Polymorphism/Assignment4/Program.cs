using System;
namespace Assignment4;
class Program 
{
    public static void Main(string[] args)
    {
        FreeLancer emp1=new FreeLancer("dharshana","ramesh","female","BTECH","Developer",28,20000);
        emp1.Salary();
        emp1.Display();
        Syncfusion emp2=new Syncfusion("Dharshana","ramesh","Female","BE","Testing",25,25000,"Chennai");
        emp2.Salary();
        emp2.Display();
    }
}