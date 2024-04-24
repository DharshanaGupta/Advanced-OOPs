using System;
using System.Security.Cryptography.X509Certificates;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        int a=10;
        int b=8;
        int c=6;
        int d=9;
        int e=10;
        GetOneArgument(a);
        GetTwoArgument(a,b);
        GetThreeArgument(a,b,c);
        GetFourArgument(a,b,c,d);
        GetFiveArgument(a,b,c,d,e);
    }
    public static void GetOneArgument(int a)
    {
        Console.WriteLine(a*a);
    }
    public static void GetTwoArgument(int a,int b)
    {
        Console.WriteLine("Square of a: "+a*a);
        Console.WriteLine("Square of b: "+b*b);

    }
     public static void GetThreeArgument(int a,int b,int c)
    {
        Console.WriteLine("Square of a: "+a*a);
        Console.WriteLine("Square of b: "+b*b);
        Console.WriteLine("Square of c: "+c*c);

    }
    public static void GetFourArgument(int a,int b,int c,int d)
    {
        Console.WriteLine("Square of a: "+a*a);
        Console.WriteLine("Square of b: "+b*b);
        Console.WriteLine("Square of c: "+c*c);
        Console.WriteLine("Square of d: "+d*d);

    }
    public static void GetFiveArgument(int a,int b,int c,int d,int e)
    {
        Console.WriteLine("Square of a: "+a*a);
        Console.WriteLine("Square of b: "+b*b);
        Console.WriteLine("Square of c: "+c*c);
        Console.WriteLine("Square of d: "+d*d);
        Console.WriteLine("Square of e: "+e*e);

    }
}