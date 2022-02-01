using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for(int i=1;i<=n;i++)
            {
                s = s + i;
            }
            Console.WriteLine(s);
        }
    }
}
