using System;
using System.Collections.Generic;
using System.Text;

namespace homework11
{
    internal class Menu
    {
        public void ShowMenu()
        {
            string path = @"C:\Users\Nikol\source\repos\c#-1\C#\homework11\Data\Product.txt";
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("Enter 1 to add product");
                Console.WriteLine("Enter 2 to show all product");
                Console.WriteLine("Enter 3 to show products by id");
                Console.WriteLine("Enter 4 to show sorted products");
                Console.WriteLine("Enter 0 to exit");
                choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                       
                        var products = File.ReadAllLines(path).ToList();
                        string maxId = products.Max(x => x.Split('|')[0]) ?? "0";
                        int newId = int.Parse(maxId) + 1;
                        Product product = new Product();
                        product.Id = newId;
                        Console.WriteLine("Enter product name:");
                        product.Name = Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        product.Price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter product description:");
                        product.Description = Console.ReadLine();
                        File.AppendAllLines(path, [product.ToString()]);
                        break;
                    case "2":
                        var products1 = File.ReadAllLines(path).ToList();
                        foreach (var item in products1)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter product ID:");
                        string productId = Console.ReadLine();
                        var productById = File.ReadAllLines(path).FirstOrDefault(x => x.Split('|')[0] == productId);
                        if (productById != null)
                        {
                            Console.WriteLine(productById);
                        }
                        else
                        {
                            Console.WriteLine("Product not found");
                        }
                        break;
                    case "4":

                        var sortedProducts = File.ReadAllLines(path).OrderBy(x => x.Split('|')[1]).ToList();
                        foreach (var item in sortedProducts)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
          
        }
    }
}
