using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("customer attached");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("customer deleted");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("customer name " + customer.CustomerName);
                Console.WriteLine("customer surname " + customer.CustomerSurname);
                Console.WriteLine("customer ıd number " + customer.CustomerId);
            }
        }
    }
}