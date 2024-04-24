using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Eco:Car,IBrand
    {
        private static int s_makingID=2000;
        private string brandName;
        private string modelName;
        public string BrandName{get{return brandName;}set{brandName=value;}}
        public string ModelName{get{return modelName;}set{modelName=value;}}
        public string MakingID{get;set;}
        public int EngineNumber{get;set;}
        public int ChasisNumber{get;set;}

        public Eco(string fuleType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven,string brandName,string modelName,int engineNumber,
        int chasisNumber):base(fuleType,numberOfSeats,color,tankCapacity,numberOfKmDriven)
        {
            s_makingID++;
            MakingID="MID"+s_makingID;
            BrandName=brandName;
            ModelName=modelName;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"FuleType: {FuleType} \nNumberOfSeats: {NumberOfSeats} \nColor: {Color} \nTankCapacity: {TankCapacity} \nNumberOfKmDriven: {NumberOfKmDriven}");
            Console.WriteLine($"BrandName: {BrandName} \nModelName: {ModelName}");
            Console.WriteLine($"MakingID: {MakingID} \nEngineNumber: {EngineNumber} \nChasisNumber: {ChasisNumber}");
            CalculateMilage();
        }
    }
}