using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 222;
            customer1.CustomerName = "Elifnaz";
            customer1.CustomerSurname = "Kaya";

            Customer customer2 = new Customer();
            customer2.CustomerId = 333;
            customer2.CustomerName = "Aleyna";
            customer2.CustomerSurname = "Köksal";

            Customer customer3 = new Customer();
            customer3.CustomerId = 444;
            customer3.CustomerName = "Elif";
            customer3.CustomerSurname = "Gıramoğlu";



            CustomerManager custom = new CustomerManager();
            custom.Add(customer1);
            custom.Delete(customer1);
            custom.Add(customer2);
            custom.Delete(customer2);
            custom.Add(customer3);
            custom.Delete(customer3);
            Console.WriteLine("---------------------");

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            custom.List(customers);


        }
    }
}
