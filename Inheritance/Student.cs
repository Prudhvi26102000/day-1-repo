using static Inheritance.Program;

namespace Inheritance
{
    partial class Program
    {
        public class Student : Person
        {
            //Person p = new Person();
            public void study()
            {
                System.Console.WriteLine("I'm studying ");
            }
            public void ShowAge()
            {
                System.Console.WriteLine("My age is: {0} years old", Age);
            }
        }
    }
}
