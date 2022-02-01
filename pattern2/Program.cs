using System;

namespace pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 1;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(s+" ");
                    s = s + 1;
                }
                Console.WriteLine("");
            }
        }
    }
}
