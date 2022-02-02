using System;
using System.Collections.Generic;

namespace Oops
{
    public class ConstructorCustomer
    {
        public int Id;
        public String Name;
        public List<Orders> Order;
        public ConstructorCustomer()
        {
            Order = new List<Orders>();
        }
        public ConstructorCustomer(int id)
            :this()
        {
            this.Id = id;
        }
        public ConstructorCustomer(int id,String name)
            :this(id)
        {
            this.Name = name;
        }
    }
}
