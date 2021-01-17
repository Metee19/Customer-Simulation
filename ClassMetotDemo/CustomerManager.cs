using System; 
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi:" + customer.name + " " + customer.surname);
        }
        public void delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi:" + customer.name + " " + customer.surname);
        }
        public void list(Customer customer)
        {
            Console.WriteLine("Müşteriler Listelendi:" + customer.name + " " + customer.surname + " " + customer.age);
        }
    }
}
