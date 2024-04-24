using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class VolumeCalculator:AreaCalculator
    {
        //property
        public int Height{get;set;}

        public override void Calculate()
        {
            double volume=Math.PI*Math.Pow(Radius,2)*Height;
            Console.WriteLine("Volume: "+volume);
        }
    }
}