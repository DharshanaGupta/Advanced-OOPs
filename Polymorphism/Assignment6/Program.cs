using System;
namespace Assignment6;
class Program 
{
    public static void Main(string[] args)
    {
        Bank bank1=new SBI();
        bank1.GetIntresetInfo();
        Bank bank2=new ICICI();
        bank2.GetIntresetInfo();
        Bank bank3=new HDFC();
        bank3.GetIntresetInfo();
        Bank bank4=new IDBI();
        bank4.GetIntresetInfo();
    }
}