using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        int number1=Square(6);
        Console.WriteLine("Square value of integer: "+number1);
        float number2= Square(5.7f);
        Console.WriteLine("Square value of float: "+number2);
        double number3=Square(7.77);
        Console.WriteLine("Square value of double: "+number3);
        long number4=Square(12345);
        Console.WriteLine("Square value of long: "+number4);
    }
    public static int Square(int number1)
    {
        return number1*number1;
    }
     public static float Square(float number2)
    {
        return number2*number2;
    }
     public static double Square(double number3)
    {
        return number3*number3;
    }
     public static long Square(long number4)
    {
        return number4*number4;
    }
}