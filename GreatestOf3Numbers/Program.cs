using System;

namespace GreatestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("Largest number is " + a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("Largest number is " + b);
            }
            else
            {
                Console.WriteLine("Largest number is " + c);
            }
        }
    }
}
