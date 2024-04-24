using System;
namespace Assignment4;
class Program 
{
    public static void Main(string[] args)
    {
        Ladieswear dress1=new Ladieswear();
        dress1.GetDressInfo();
        dress1.DisplayInfo();

        Menswear dress2=new Menswear();
        dress2.GetDressInfo();
        dress2.DisplayInfo();
    }
}