using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Car
    {
        /*Property: FuleType, NumberOfSeats, Color, TankCapacity, NumberOfKmDriven

        Method: CalculateMilage*/
        public string FuleType{get;set;}
        public int NumberOfSeats{get;set;}
        public string Color{get;set;}
        public int TankCapacity{get;set;}
        public int NumberOfKmDriven{get;set;}

        public Car(string fuleType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven)
        {
            FuleType=fuleType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;

        }
        public void CalculateMilage()
        {
            double Milage=(double)NumberOfKmDriven/TankCapacity;
            Console.WriteLine("Milage: "+Math.Round(Milage,2));
        }
    }
}