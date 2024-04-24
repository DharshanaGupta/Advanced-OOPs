using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MetroCardManagemnet
{
    public static class Operations
    {
        static UserDetails currentUser;
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelList=new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketFairList=new CustomList<TicketFairDetails>();

        public static void MainMenu()
        {
            Console.WriteLine("*******MainMenu*******");
            string mainOption="yes";
            do{
                Console.WriteLine("1.Registration \n2.Login \n3.Exit");
                int mainCoice=int.Parse(Console.ReadLine());
                switch(mainCoice)
                {
                    case 1:
                    {
                        Console.WriteLine("*********Registration*******");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("******Login*******");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Application Exited Successfully");
                        mainOption="no";
                        break;
                    }
                }
            }while(mainOption=="yes");
        }

        //registration
        public static void Registration()
        {
            System.Console.Write("Enter your Name: ");
            string username=Console.ReadLine();
            System.Console.Write("Enter your Phone Number: ");
            string phone=Console.ReadLine();
            Console.Write("Enter the Balance: ");
            double balance=double.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(username,phone,balance);
            userList.Add(user);

            Console.WriteLine("You have Registered Successfully , your card number is "+user.CardNumber);
        }
        //registration ends

        //Login
        public static void Login()
        {
            //get card number from user and validate
            Console.WriteLine("Enter your Card Number: ");
            string cNumber=Console.ReadLine().ToUpper();
            bool flag = true;
            foreach(UserDetails user in userList)
            {
                if(cNumber.Equals(user.CardNumber))
                {
                    //if exists display submenu
                    currentUser=user;
                    flag=false;
                    SubMenu();
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid Card Number");
            }
        }
        //login ends

        //submneu
        public static void SubMenu()
        {
            Console.WriteLine("********Submenu*******");
            string subOption="yes";
            do{
                Console.WriteLine("1.Balance Check \n2.Recharge \n3.View Travel History \n4.Travel \n5.Exit");
                int subChoice=int.Parse(Console.ReadLine());
                switch(subChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("*****BalanceCheck****");
                        BalanceCheck();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("*******Recharge******");
                        Recharge();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("******View Travel History*******");
                        TravelHistory();
                        break;

                    }
                    case 4:
                    {
                        Console.WriteLine("******Travel******");
                        Travel();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Taking Back to main Menu");
                        subOption="no";
                        break;
                    }
                }
            }while(subOption=="yes");
        }
        //submenu ends

        //balance check
        public static void BalanceCheck()
        {
            Console.WriteLine("Your Balance is :"+currentUser.Balance);
        }
        //balance check ends

        //Recharge
        public static void Recharge()
        {
            Console.Write("Enter the Amount to be Recharged: ");
            double amount=double.Parse(Console.ReadLine());
            currentUser.WalletRecharge(amount);
            Console.WriteLine("Recharged Successfully");
        }
        //Recharge ends

        //travel history
        public static void TravelHistory()
        {
            Console.WriteLine("|TravelID|CardNumber|FromLocation|ToLocation|Date|TravelCost|");
            bool flag=true;
            foreach(TravelDetails travel in travelList)
            {
                if(currentUser.CardNumber.Equals(travel.CardNumber))
                {
                    flag=false;
                    Console.WriteLine($"|{travel.TravelID}|{travel.CardNumber}|{travel.FromLocation}|{travel.ToLocation}|{travel.Date}|{travel.TravelCost}");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("You have No travel Details");
            }
        }
        //travel history ends

        //Travel
        public static void Travel()
        {
            //show ticket fair details and ask user to select ticket id
            Console.WriteLine("|TicketID|FromLocation|Tolocation|Fair|");
            foreach(TicketFairDetails ticketFair in ticketFairList)
            {
                Console.WriteLine($"|{ticketFair.TicketID}|{ticketFair.FromLocation}|{ticketFair.ToLocation}|{ticketFair.TicketPrice}|");
            }
            Console.WriteLine("Enter the ticket ID: ");
            string ticketID=Console.ReadLine().ToUpper();
            //check the ticket id is valid
            bool flag=true;
            foreach(TicketFairDetails fairDetails in ticketFairList)
            {
                if(ticketID.Equals(fairDetails.TicketID))
                {
                    flag=false;
                    //check user has sufficient balance
                    if(currentUser.Balance>fairDetails.TicketPrice)
                    {
                        double amount=fairDetails.TicketPrice;
                        currentUser.DeductBalance(amount);
                        TravelDetails travels=new TravelDetails(currentUser.CardNumber,fairDetails.FromLocation,fairDetails.ToLocation,DateTime.Now,fairDetails.TicketPrice);
                        travelList.Add(travels);
                        Console.WriteLine("Travel history Added Successfully");
                    }
                    else{
                        Console.WriteLine("Please Recharge amount");
                    }
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid Ticket ID");
            }
        }



        public static void AddDefaultData()
        {
            UserDetails user1=new UserDetails("Ravi","9848812345",1000);
            UserDetails user2=new UserDetails("baskaran","9948854321",1000);
            userList.Add(user1);
            userList.Add(user2);

            TravelDetails travel1=new TravelDetails("CMRL1001","Airport","Egmore",new DateTime(2023,10,10),55);
            TravelDetails travel2=new TravelDetails("CMRL1001","Egmore","Koyambedu",new DateTime(2023,10,10),32);
            TravelDetails travel3=new TravelDetails("CMRL1002","Alandur","Koyambedu",new DateTime(2023,11,10),25);
            TravelDetails travel4=new TravelDetails("CMRL1002","Egmore","Thirumangalam",new DateTime(2023,11,10),25);
            travelList.Add(travel1);
            travelList.Add(travel2);
            travelList.Add(travel3);
            travelList.Add(travel4);

            TicketFairDetails ticketFair1=new TicketFairDetails("Airport","Egmore",55);
            TicketFairDetails ticketFair2=new TicketFairDetails("Airport","Koyambedu",25);
            TicketFairDetails ticketFair3=new TicketFairDetails("Alandur","Koyambedu",25);
            TicketFairDetails ticketFair4=new TicketFairDetails("Koyambedu","Egmore",32);
            TicketFairDetails ticketFair5=new TicketFairDetails("Vadapalani","Egmore",45);
            TicketFairDetails ticketFair6=new TicketFairDetails("Arumbakkam","Egmore",25);
            TicketFairDetails ticketFair7=new TicketFairDetails("Vadapalani","Koyambedu",25);
            TicketFairDetails ticketFair8=new TicketFairDetails("Arumbakkam","Koyambedu",16);
            ticketFairList.Add(ticketFair1);
            ticketFairList.Add(ticketFair2);
            ticketFairList.Add(ticketFair3);
            ticketFairList.Add(ticketFair4);
            ticketFairList.Add(ticketFair5);
            ticketFairList.Add(ticketFair6);
            ticketFairList.Add(ticketFair7);
            ticketFairList.Add(ticketFair8);
        }
        
    }
}