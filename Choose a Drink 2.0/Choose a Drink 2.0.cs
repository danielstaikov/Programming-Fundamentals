using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double bill=0;
            switch (profession)
            {
                case "Athlete":
                    bill = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    bill = 1.00;
                    break;
                case "SoftUni Student":
                    bill = 1.70;
                    break;
                default:
                    bill = 1.20;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {quantity*bill:f2}.");
        }
    }
}
