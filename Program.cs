using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Ole";
            customer.Age = 25;
            customer.CustomerID = 50001;
            Console.WriteLine(customer);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
    }
    class Customer : Person
    {
        public int CustomerID { get; set; }
    }
}
