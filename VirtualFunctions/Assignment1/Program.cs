using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        AreaCalculator area=new AreaCalculator();
        area.Radius=10;
        area.Calculate();
        VolumeCalculator volume=new VolumeCalculator();
        volume.Radius=area.Radius;
        volume.Height=15;
        volume.Calculate();
    }
}