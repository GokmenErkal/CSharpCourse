using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Bilgisayar" },
                new Category { CategoryId = 2, CategoryName = "Telefon" },
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 3000, UnitsInStock = 10},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "64 GB Ram", UnitPrice = 2000, UnitsInStock = 8},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 1000, UnitsInStock = 4},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "iPhone 15", QuantityPerUnit = "6 GB Ram", UnitPrice = 4000, UnitsInStock = 2},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Samsung 24", QuantityPerUnit = "8 GB Ram", UnitPrice = 5000, UnitsInStock = 11},
            };

            Console.WriteLine("Algoritmik ------------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 3000 && product.UnitsInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            
            Console.WriteLine("Linq ------------------");
            var result = products.Where(product => product.UnitPrice > 3000 && product.UnitsInStock > 5);

            foreach (var r in result)
            {
                Console.WriteLine(r.ProductName);
            }

            GetProducts(products);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 3000 && product.UnitsInStock > 5)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 3000 && product.UnitsInStock > 5).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
