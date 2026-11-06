using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
    internal class Menu
    {
        public void ShowMenu()
        {
            string choice = "";
            while(choice != "0")
            {
                Console.WriteLine("Enter 1 to add product");
                Console.WriteLine("Enter 2 to show all product");
                Console.WriteLine("Enter 3 to show products by id");
                Console.WriteLine("Enter 4 to show sorted products");
                Console.WriteLine("Enter 0 to exit");
                choice = Console.ReadLine();
            }
            switch(choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
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
