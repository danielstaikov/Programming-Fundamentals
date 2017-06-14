using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int numberOfItems = int.Parse(Console.ReadLine());

            double priceTotal = 0;

            for (int i = 1; i <= numberOfItems; i++)
            {
                string nameOfItem = Console.ReadLine();

                double priceOfItem = double.Parse(Console.ReadLine());

                int countOfItem = int.Parse(Console.ReadLine());

                if (countOfItem > 1)
                {
                    Console.WriteLine($"Adding {countOfItem} {nameOfItem}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {countOfItem} {nameOfItem} to cart.");
                }


                priceTotal = priceOfItem *countOfItem + priceTotal;
            }

            Console.WriteLine($"Subtotal: ${priceTotal:f2}");

            if (budget >= priceTotal)
            {
                Console.WriteLine($"Money left: ${budget - priceTotal:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${priceTotal - budget:f2} more.");
            }

        }
    }
}
