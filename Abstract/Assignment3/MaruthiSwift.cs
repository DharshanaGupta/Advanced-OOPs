using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class MaruthiSwift:Car
    {
        public override void GetEngineType()
        {
            Console.WriteLine("Enter the Engine Type (Petrol,diesel,cng)");
            EngineType=Console.ReadLine();
        }
        public override void GetNoOfseats()
        {
            Console.WriteLine("Enter number of Seats");
            NoofSeats=int.Parse(Console.ReadLine());
        }
        public override void GetPrice()
        {
            Console.WriteLine("Enter price of Car");
            Price=double.Parse(Console.ReadLine());
        }
        public override void GetCarType()
        {
            Console.WriteLine("Enter car type (hatchback,sedan, suv)");
            CarType=Console.ReadLine();
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("*******MaruthiSwift*******");
            Console.WriteLine($"NoofWheels: {NoOfWheels} \nNoOfDoors: {NoofDoors} \nEngineType: {EngineType} \nNoOfSeats: {NoofSeats} \nPrice: {Price} \nCarType: {CarType}");
        }
        
    }
}