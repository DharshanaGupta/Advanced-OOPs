using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Ladieswear:Dress
    {
        private string dressType;
        private string dressName;
        private double price;
        private double totalPrice;
        public override string DressType{get{return dressType;}set{dressType=value;}}
        public override string DressName{get{return dressName;}set{dressName=value;}}
        public override double Price{get{return price;}set{price=value;}}
        public override double TotalPrice{get{return totalPrice;}set{totalPrice=value;}}
        public override void GetDressInfo()
        {
           Console.WriteLine("Enter Dress Type (Ladieswear, menswear, childrenswear)");
           DressType=Console.ReadLine();
           Console.WriteLine("Enter the Dress name");
           DressName=Console.ReadLine();
           Console.WriteLine("Enter the Price");
           Price=double.Parse(Console.ReadLine());
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("**********Ladieswear Info*********");
            double discount=(double)20/100*Price;
            double total=Price-discount;
            TotalPrice=total;
            Console.WriteLine($"DressType: {DressType} \nDressName: {DressName} \nPrice: {Price} \nTotalPrice: {TotalPrice}");
        }

    }
}