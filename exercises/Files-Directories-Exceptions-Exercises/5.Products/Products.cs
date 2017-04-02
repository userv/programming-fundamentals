using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace _5.Products
{
    public class Products
    {
        private static List<Product> productsDb = new List<Product>();
        private static string productsDbFile = "productsDbFile.txt";
        private static List<string> productTypes = new List<string>
        {
           "Domestics","Electronics", "Food"
        };

        public class Product
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        public static void Main()
        {
            if (File.Exists(productsDbFile))
            {
                ReadStockedProducts();
            }
            else
            {
                File.Create(productsDbFile).Close();
            }

            string inputLine = Console.ReadLine();
            while (inputLine != "exit")
            {
                string[] inputParams = inputLine.Split(' ');
                string command = inputParams[0];
                if (inputParams.Length == 4)
                {
                    string name = inputParams[0];
                    string type = inputParams[1];
                    decimal price = decimal.Parse(inputParams[2]);
                    int quantity = int.Parse(inputParams[3]);
                    AddProduct(name, type, price, quantity);
                }
                switch (command)
                {
                    case "stock":
                        StockProducts();
                        break;
                    case "sales":
                        PrintIncomeByType();
                        break;
                    case "analyze":
                        Analize();
                        break;
                }

                inputLine = Console.ReadLine();

            }
        }

        public static void Analize()
        {
            foreach (var type in productTypes.OrderBy(n => n))
            {
                foreach (var product in productsDb.Where(p => p.Type == type))
                {
                    Console.WriteLine($"{type}, Product: {product.Name}");
                    Console.WriteLine($"Price: ${product.Price}, Amount Left: {product.Quantity}");
                }
            }
        }

        public static void PrintIncomeByType()
        {

            foreach (var type in productTypes.OrderByDescending(p => p))
            {
                var incomeByType = productsDb.Where(t => t.Type == type).Select(p => p.Price * p.Quantity).Sum();
                if (incomeByType == 0)
                {
                    //   Console.WriteLine("No products stocked");
                    continue;
                }
                Console.WriteLine($"{type}: ${incomeByType}");
            }

        }

        public static void StockProducts()
        {
            List<string> productsList = new List<string>();
            foreach (var product in productsDb)
            {
                string productData =
                    $"{product.Name} {product.Type} {product.Price} {product.Quantity}";
                productsList.Add(productData);
            }
            File.WriteAllLines(productsDbFile, productsList);
        }

        public static void AddProduct(string name, string type, decimal price, int quantity)
        {
            if (productsDb.Where(p => p.Name == name).Any(p => p.Type == type))
            {
                var currentProduct = productsDb
                    .Where(p => p.Name == name)
                    .Where(p => p.Type == type)
                    .Select(p => p);
                currentProduct.Select(p =>
                {
                    p.Price = price;
                    p.Quantity = quantity;
                    return p;
                }).ToList();
                return;
            }
            Product newProduct = new Product
            {
                Name = name,
                Type = type,
                Price = price,
                Quantity = quantity
            };
            productsDb.Add(newProduct);



        }

        public static void ReadStockedProducts()
        {
            string[] products = File.ReadAllLines(productsDbFile);
            foreach (var product in products)
            {
                string[] productData = product.Split(' ');
                string name = productData[0];
                string type = productData[1];
                decimal price = decimal.Parse(productData[2]);
                int quantity = int.Parse(productData[3]);
                Product p = new Product
                {
                    Name = name,
                    Type = type,
                    Price = price,
                    Quantity = quantity
                };
                productsDb.Add(p);
            }
        }
    }
}
