using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Added();
            customerManager.Updated();

            ProductManager productManager = new ProductManager();
            productManager.Added();
            productManager.Updated();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Gokmen";
            customer.LastName = "Erkal";
            customer.City = "Sakarya";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Mert",
                LastName = "Bulut",
                City = "Manisa"
            };


            Console.ReadLine();
        }
    }
}
