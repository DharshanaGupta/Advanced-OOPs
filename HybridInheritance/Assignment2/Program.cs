using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        SavingsAccount customer1=new SavingsAccount("Dharshana","female",new DateTime(2002,08,04),12345678,"23456FGG","123456787654","FGHJ3456","123456789","Savings",1000);
        //Console.WriteLine("--------------------------------");

        // customer1.BalanceCheck();
        // customer1.Deposit();
        // customer1.Withdraw();
        
        
        Console.WriteLine("----------------------------------");

        SavingsAccount customer2=new SavingsAccount("xxxx","female",new DateTime(2002,06,04),12345678,"23458FGG","1234512787654","FRTJ3456","123445789","Savings",20000);
        Console.WriteLine("----------------------------------");
        customer2.BalanceCheck();
        customer2.Deposit();
        customer2.Withdraw();
        
        Console.WriteLine("----------------------------------");
    }
}