using System;
namespace Assignment4;
class Program 
{
    public static void Main(string[] args)
    {
        //d.	1.1,65.3,93.9,55.5,3.5,6.9 find-3.5
        double[] arr={1.1,65.3,93.9,55.5,3.5,6.9};
        int result=LinearSearch(arr,3.5);
        if(result>-1)
        {
            Console.WriteLine("Element found at "+result);

        }
        else 
        {
            Console.WriteLine("Element not found");
        }
    }
    static int LinearSearch(double[] arr,double search)
    {
        int position=-1;
        for(int i=0;i<arr.Length-1;i++)
        {
            if(arr[i].Equals(search))
            {
                position=i;
                break;
            }
        }
        return position;
    }
}