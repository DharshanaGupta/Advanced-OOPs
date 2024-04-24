using System;
namespace Assignment1;
class Program 
{
    public static void Main(string[] args)
    {
        //a.	45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77  -> Find 66
        int[] arr={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        int result=LinearSearch(arr,66);
        if(result>-1)
        {
            Console.WriteLine("Element found at "+result);
        }
        else{
            Console.WriteLine("Element not found");
        }
    }
    static int LinearSearch(int[] arr, int search)
    {
        int position=-1;
        for(int i=0;i<arr.Length-1;i++)
        {
            if(arr[i]==search)
            {
                position=i;
                break;
            }
        }
        return position;;
    }
}