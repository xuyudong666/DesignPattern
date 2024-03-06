using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesignPattern.Clones
{
    public class Customer : ICloneable
    {
        public Customer()
        {

        }
        public Customer(string name, int age, Address address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            var json = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<Customer>(json);
        }
    }
}
