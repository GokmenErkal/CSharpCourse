using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Ali", LastName = "Yıldız", City = "İzmir"};

            Customer customer2 = new Customer(2, "Gokmen", "Erkal", "Sakarya");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ayşe";
            customer3.LastName = "Ay";
            customer3.City = "Van";

            Console.WriteLine(customer2.FirstName);
        }
    }

    class  Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
