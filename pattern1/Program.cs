﻿using System;

namespace pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<i+1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
