using System;

namespace count
{
    class Program
    {
        static void Main1(string[] args)
        {
            int c = 0;
            Console.WriteLine("Enter length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a= new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            int[] b = new int[256];
            for(int i=0;i<n;i++)
            {
                b[a[i]] += 1;
            }
            for(int i=0;i<b.Length;i++)
            {
                if(b[i]>1)
                {
                    c += 1;
                }
            }
            Console.WriteLine("Repeated elements in an array "+c);

        }
    }
}
