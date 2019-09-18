using System;

namespace CSharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Name);

            var customerOne = new Customer(123,"Mike");

            System.Console.WriteLine(customerOne.ID);
            System.Console.WriteLine(customerOne.Name);

        }
    }
}
