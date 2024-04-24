using System;
namespace Assignment3;
class Program 
{
    public static void Main(string[] args)
    {
        //c.	c,a,f,b,k,h,j,I,i,z,t,m,p,l,d -> Find m
        char[] arr={'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        int result=LinearSearch(arr,'m');
        if(result>-1)
        {
            Console.WriteLine("Element found at "+result);

        }
        else 
        {
            Console.WriteLine("Element not found");
        }

    }
    static int LinearSearch(char[] arr,char search)
    {
        int position=-1;
        for(int i=0;i<arr.Length-1;i++)
        {
            if(arr[i].Equals(search))
            {
                position=i;
            }
        }
        return position;
    }
}