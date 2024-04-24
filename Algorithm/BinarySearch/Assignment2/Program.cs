using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        //b.	SF3023, SF3021, SF3067, SF3043, SF3053, SF3032, SF3063, SF3089, SF3062, SF3092 -> Find - SF3067
        string[] arr={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        int result=BinarySearch(arr,"SF3069");
        if(result>-1)
        {
            Console.WriteLine("Element found at "+result);
        }
        else 
        {
            Console.WriteLine("Element not found");
        }
    }
    public static int BinarySearch(string[] arr, string search)
    {
        int left=0;
        int right=arr.Length-1;
        while(left<=right)
        {
            int mid=left+((right-left)/2);
            int res=search.CompareTo(arr[mid]);
            if(res==0)
            {
                return mid;
            }
            else if(res>0)
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