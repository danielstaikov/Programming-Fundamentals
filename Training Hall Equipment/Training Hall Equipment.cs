using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double subTotal = 0;
            for (int i = 0; i < numberOfItems; i++)//*3
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount ==1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                subTotal = itemPrice * (double)itemCount+ subTotal;

            }
            Console.WriteLine($"Subtotal: ${subTotal:f2}");


            if (subTotal> budget)
            {
                Console.WriteLine($"Not enough. We need ${subTotal - budget:f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget- subTotal:f2}");
            }
        }
    }
}