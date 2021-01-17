using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.name = "Metehan";
            customer1.surname = "Ceyhan";
            customer1.age = 21;
            customer1.gender = "male";
            customer1.moneyInBank = 0;
            customer1.add(customer1);
            customer1.list(customer1);
            customer1.delete(customer1);

            Customer customer2 = new Customer();
            customer2.name = "Fatmanur";
            customer2.surname = "Ceyhan";
            customer2.age = 21;
            customer2.gender = "female";
            customer2.moneyInBank = 300000;
            customer2.add(customer2);
            customer2.list(customer2);
            customer2.delete(customer2);

            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Company Customer:" + customer.name + " " + customer.surname);
            }
        }

    }
}
