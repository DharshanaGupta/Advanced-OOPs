using System;
namespace Assignment2;
class Program 
{
    public static void Main(string[] args)
    {
        //b.	SF3023, SF3021, SF3067, SF3043, SF3053, SF3032, SF3063, SF3089, SF3062, SF3092 Find - SF3067
        string[] arr={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        int result=LinearSearch(arr,"SF3067");
        if(result>-1)
        {
            Console.WriteLine("Element found at "+result);

        }
        else 
        {
            Console.WriteLine("Element not found");
        }
    }

    static int LinearSearch(string[] arr,string search)
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