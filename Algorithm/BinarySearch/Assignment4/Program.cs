using System;
namespace Assignment4;
class Program 
{
    public static void Main(string[] args)
    {
        //d.	1.1,65.3,93.9,55.5,3.5,6.9 -> find 3.5
        double[] arr={1.1,65.3,93.9,55.5,3.5,6.9};
        Array.Sort(arr);
        int result=BinarySearch(arr,3.5);
        if(result>-1)
        {
            Console.WriteLine("Element found at "+result);
        }
        else{
            Console.WriteLine("Element not found");
        }
    }

    public static int BinarySearch(double[] arr, double search)
    {
        int left=0;
        int right=arr.Length-1;
        while(left<=right)
        {
            int mid=left+((right-left)/2);
            if(arr[mid]==search)
            {
                return mid;
            }
            else if(arr[mid]<search)
            {
                left=mid+1;
            }
            else{
                right=mid-1;
            }
        }
        return -1;
    }
}