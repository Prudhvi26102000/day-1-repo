using System;

namespace Oops
{
    public class Person
    {
        public String name;
        public void Introduce(String to)
        {
            Console.WriteLine("Hi {0},this is {1}", to, name);
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Naruto";
            person.Introduce("Hinata");
            //Console.WriteLine("basic refernce objects and classes");
            var customer=new ConstructorCustomer();
            var order = new Orders();
            customer.Order.Add(order);
            customer.Id = 1;
            customer.Name = "John";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            //Console.WriteLine("above things are about constructors");
            var e= new Encapsulation();
            e.SetBirthDate(new DateTime(1992, 1, 1));
            Console.WriteLine(e.GetBirthDate());
        }
    }
}
