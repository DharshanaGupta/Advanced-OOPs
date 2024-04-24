using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public abstract class Car
    {
        /*Field: No. of wheels=4, No.Of.Doors = 4,
        Properties: Engine type -Petrol,diesel,cng, No.Of.Seats, Price, CarType -hatchback,sedan, suv

        Methods : ShowWheels, show doors*/
        private int noOfWheels=4;
        private int noOFDoors=4;

        public int NoOfWheels{get{return noOfWheels;}}
        public int NoofDoors{get{return noOFDoors;}}
        public string EngineType{get;set;}
        public int NoofSeats{get;set;}
        public double Price{get;set;}
        public string CarType{get;set;}

        public void ShowWheels()
        {
            Console.WriteLine(NoOfWheels);
        }
        public void Doors()
        {
            Console.WriteLine(NoofDoors);
        }

        // public Car(string engineType,int noofSeats,double price,string carType)
        // {
        //     EngineType=engineType;
        //     NoofSeats=noofSeats;
        //     Price=price;
        //     CarType=carType;

        // }
        public abstract void GetEngineType();
        public abstract void GetNoOfseats();
        public abstract void GetPrice();
        public abstract void GetCarType();
        public abstract void DisplayInfo();
    }
}