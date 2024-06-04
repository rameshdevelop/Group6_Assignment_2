using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group6_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(100, "External Hard Drive", 79.99, 70);

            bool continueOperation = true;

            while (continueOperation)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Increment stock");
                Console.WriteLine("2. Decrement stock");
                Console.WriteLine("3. Close");
                Console.WriteLine("\n");

                string operationChoice = FetchStringFromConsole("Choose Your option:");

                switch (operationChoice)
                {
                    case "1":
                        AddToStock(product);
                        break;
                    case "2":
                        ReduceStock(product);
                        break;
                    case "3":
                        continueOperation = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Please try again.");
                        break;
                }
            }
        }

        static void AddToStock(Product product)
        {
            int increaseAmount = FetchIntegerFromConsole("Enter the quantity to increase the stock by:");
            product.IncreaseStock(increaseAmount);
            Console.WriteLine($"Stock increased by {increaseAmount}. New stock: {product.Stock} \n");
        }

        static void ReduceStock(Product product)
        {
            int decreaseAmount = FetchIntegerFromConsole("Enter the quantity to decrease the stock by:");
            product.DecreaseStock(decreaseAmount);
            Console.WriteLine($"Stock decreased by {decreaseAmount}. New stock: {product.Stock} \n");
        }

        static string FetchStringFromConsole(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine()?.Trim() ?? "";

            while (String.IsNullOrEmpty(userInput))
            {
                userInput = Console.ReadLine()?.Trim() ?? "";
            }
            return userInput;
        }

        static int FetchIntegerFromConsole(string message)
        {
            Console.WriteLine(message);
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please Enter a valid input.");
            }
            return userInput;
        }
    }
}
