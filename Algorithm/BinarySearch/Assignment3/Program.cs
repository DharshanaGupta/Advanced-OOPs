using System;
namespace Assignment3;
class Program 
{
    public static void Main(string[] args)
    {
        //c.	c,a,f,b,k,h,j,I,i,z,t,m,p,l,d -> Find m

        char[] arr={'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        int results=BinarySearch(arr,'m');
        if(results>-1)
        {
            Console.WriteLine("Element found at "+results);
        }
        else{
            Console.WriteLine("Element not found");
        }

    }
    public static int BinarySearch(char[] arr, char search)
    {
        int left=0;
        int right=arr.Length-1;
        while(left<=right)
        {
            int mid=left+((right-left)/2);
            int result=search.CompareTo(arr[mid]);
            if(result==0)
            {
                return mid;
            }
            else if(result>0)
            {
                left=mid+1;
            }
            else{
                right=mid-1;
            }
        }
        return-1;
    }
}