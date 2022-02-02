using System;

namespace _2ndLargestElementInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int l1=0,l2=0;
            for(int i=0;i<n;i++)
            {
                if (a[i] > l1)
                {
                    l1 = a[i];
                }
            }
            for(int i=0;i<n;i++)
            {
                if (a[i] > l2 && a[i] != l1)
                {
                    l2 = a[i];
                }
            }
            Console.WriteLine("Second Largest element in the array is "+l2);

        }
    }
}
