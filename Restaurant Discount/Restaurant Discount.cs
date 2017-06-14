using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();
            double packagePrice = 0;
            double packageDiscount = 0;
            double priceDiscount = 0;
            switch (servicePackage)
            {
                case "Normal":
                    packagePrice = 500;
                    packageDiscount = 0.95;
                    break;
                case "Gold":
                    packagePrice = 750;
                    packageDiscount = 0.90;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    packageDiscount = 0.85;
                    break;
            }
            if (groupSize<=50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                priceDiscount = (2500 + packagePrice) * packageDiscount;
                Console.WriteLine($"The price per person is {priceDiscount/ groupSize:f2}$");
            }
            else if (groupSize<=75)
            {
                Console.WriteLine("We can offer you the Terrace");
                priceDiscount = (5000 + packagePrice) * packageDiscount;
                Console.WriteLine($"The price per person is {priceDiscount / groupSize:f2}$");

            }
            else if (groupSize <=120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                priceDiscount = (7500 + packagePrice) * packageDiscount;
                Console.WriteLine($"The price per person is {priceDiscount / groupSize:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
