using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double totalMoney = currentBalance;

            string buyingGames = Console.ReadLine();

            while (buyingGames != "Game Time")
            {

                switch (buyingGames)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99)
                        {
                            currentBalance -= 39.99;
                            Console.WriteLine($"Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        if (currentBalance >= 15.99)
                        {
                            currentBalance -= 15.99;
                            Console.WriteLine($"Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (currentBalance >= 19.99)
                        {
                            currentBalance -= 19.99;
                            Console.WriteLine($"Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        if (currentBalance >= 59.99)
                        {
                            currentBalance -= 59.99;
                            Console.WriteLine($"Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch":
                        if (currentBalance >= 29.99)
                        {
                            currentBalance -= 29.99;
                            Console.WriteLine($"Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99)
                        {
                            currentBalance -= 39.99;
                            Console.WriteLine($"Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                buyingGames = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalMoney - currentBalance:f2}. Remaining: ${currentBalance:f2}");

        }
    }
}