using System;

using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MetroCardManagemnet
{
    public static class FileHandling
    {
        public static void Create()
        {
            //creating folder
            if(!Directory.Exists("MetroCardManagement"))
            {
                Console.WriteLine("Creating Folder..");
                Directory.CreateDirectory("MetroCardManagement");
            }

            //creating file UserDetails,Travel Details,TicketFair Details

            if(!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                Console.WriteLine("Creating File..");
                File.Create("MetroCardManagement/UserDetails.csv");
            }
            if(!File.Exists("MetroCardManagement/TravelDetails.csv"))
            {
                Console.WriteLine("Creating File..");
                File.Create("MetroCardManagement/TravelDetails.csv");
            }

            if(!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                Console.WriteLine("Creating File..");
                File.Create("MetroCardManagement/TicketFairDetails.csv");
            }

        }
    
        public static void WriteToCSV()
        {
            //userdetails
            string[] users=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                users[i]=Operations.userList[i].CardNumber+","+Operations.userList[i].UserName+","+Operations.userList[i].Phone+","+Operations.userList[i].Balance;
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv",users);

            //traveldetails
            string[] travels=new string[Operations.travelList.Count];
            for(int i=0;i<Operations.travelList.Count;i++)
            {
                travels[i]=Operations.travelList[i].TravelID+","+Operations.travelList[i].CardNumber+","+Operations.travelList[i].FromLocation+","+Operations.travelList[i].ToLocation+","+Operations.travelList[i].Date.ToString("dd/MM/yyyy")+","+Operations.travelList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardManagement/TravelDetails.csv",travels);

            //ticket fair details
            string[] ticketsFair=new string[Operations.ticketFairList.Count];
            for(int i=0;i<Operations.ticketFairList.Count;i++)
            {
                ticketsFair[i]=Operations.ticketFairList[i].TicketID+","+Operations.ticketFairList[i].FromLocation+","+Operations.ticketFairList[i].ToLocation+","+Operations.ticketFairList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardManagement/TicketFairDetails.csv",ticketsFair);
        }

        public static void ReadFromCSV()
        {
            string[] users=File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operations.userList.Add(user1);
            }

            string[] travels=File.ReadAllLines("MetroCardManagement/TravelDetails.csv");
            foreach(string travel in travels)
            {
                TravelDetails travel1=new TravelDetails(travel);
                Operations.travelList.Add(travel1);
            }

            string[] ticketsFair=File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            foreach(string ticketsFair1 in ticketsFair)
            {
                TicketFairDetails tickets=new TicketFairDetails(ticketsFair1);
                Operations.ticketFairList.Add(tickets);
            }
        }
    }

}