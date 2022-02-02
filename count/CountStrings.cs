using System;
using System.Collections.Generic;
using System.Text;

namespace count
{
    class CountStrings
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int alp = 0, dig = 0, sc = 0;
            for(int i=0;i<s.Length;i++)
            {
                if((s[i]>='a' && s[i]<='z') || s[i]>='A' && s[i]<='Z')
                {
                    alp++;
                }
                else if(s[i]>='0' && s[i]<='9')
                {
                    dig++;
                }
                else
                {
                    sc++;
                }
            }
            Console.WriteLine("Alphabets in String "+alp);
            Console.WriteLine("digits in String " + dig);
            Console.WriteLine("Special Characters in String "+ sc);
        }

    }
}
