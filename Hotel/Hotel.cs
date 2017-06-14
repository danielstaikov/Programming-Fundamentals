using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int accommodations = int.Parse(Console.ReadLine());
            double studioDayPrice = 0;
            double doubleDayPrice = 0;
            double suiteDayPrice = 0;
            double studioDiscount = 1;
            double doubleDiscount = 1;
            double suiteDiscount = 1;
            int accommodationsStudio = accommodations;

            if (month.ToLower() == "may" || month.ToLower() == "october") 
            {
                studioDayPrice = 50;
                doubleDayPrice = 65;
                suiteDayPrice = 75;
                if (accommodations > 7)
                {
                    studioDiscount = 0.95;
                    if (month.ToLower() == "october")
                    {
                        accommodationsStudio = accommodations - 1;
                    }

                }

            }
            else if (month.ToLower() == "june" || month.ToLower() == "september") 
            {
                studioDayPrice = 60;
                doubleDayPrice = 72;
                suiteDayPrice = 82;
                if (accommodations > 14)
                {
                    doubleDiscount = 0.9;
                    if (month.ToLower() == "september")
                    {
                        accommodationsStudio = accommodations - 2;
                    }
                }
                else if (accommodations > 7 & month.ToLower() == "september")
                {
                    accommodationsStudio = accommodations - 1;
                }
                else
                {
                    // sorry no bonus
                }

            }
            else 
            {
                studioDayPrice = 68;
                doubleDayPrice = 77;
                suiteDayPrice = 89;
                if (accommodations > 14)
                {
                    suiteDiscount = 0.85;
                }

            }
            double studioPrice = studioDayPrice * accommodationsStudio * studioDiscount;
            double doublePrice = doubleDayPrice * accommodations * doubleDiscount;
            double suitePrice = suiteDayPrice * accommodations * suiteDiscount;

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");

        }
    }
}
