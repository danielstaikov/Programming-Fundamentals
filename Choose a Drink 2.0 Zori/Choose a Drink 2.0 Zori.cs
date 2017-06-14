using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0_Zori
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;

            double sum = 0;

            if (profession == "Athlete")
            {
                sum = water * quantity;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else if ((profession == "Businessman") || (profession == "Businesswoman"))
            {
                sum = quantity * coffee;

                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                sum = quantity * beer;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else
            {
                sum = quantity * tea;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
        }
    }
}
