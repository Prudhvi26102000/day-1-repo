using System;

namespace Inheritance
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.greet();
            var s = new Student();
            s.SetAge(21);
            s.ShowAge();
            Professor pr = new Professor();
            pr.SetAge(45);
            pr.greet();
            pr.Explain();
            //Console.WriteLine("Hello World!");
        }
    }
}
