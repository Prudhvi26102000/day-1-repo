namespace Inheritance
{
    partial class Program
    {
        public class Person
        {
            public int Age;
            public void greet()
            {
                System.Console.WriteLine("Hello Everyone");
            }
            public void SetAge(int age)
            {
                this.Age = age;
            }
        }
    }
}
