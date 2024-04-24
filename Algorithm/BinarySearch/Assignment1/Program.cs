using System;
namespace Assignmnet1;
class Program 
{
    public static void Main(string[] args)
    {
        //a.	45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77    -> Find 66
        int[] arr={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        Array.Sort(arr);
        int result=BinarySearch(arr,66);
        
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
        if(result>-1)
        {
            Console.WriteLine("Element found at "+result);
        }
        else{
            Console.WriteLine("Element not found");
        }
    }

    public static int BinarySearch(int[] arr,int search)
    {
        int left=0;
        int right=arr.Length-1;
        while(left<=right)
        {
            int mid = left + ((right - left) / 2);
            if (arr[mid] == search)
            {
                return mid;
            }
            else if (arr[mid] < search)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
            
        }
        return -1;
    }
}