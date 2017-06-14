using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int caloriesCount = 0;
            for (int i = 0; i < numberOfIngredients; i++)
            {
                string ingredients = Console.ReadLine();
                string ingered = ingredients.ToLower();

                switch (ingered)
                {
                    case "cheese"://500 calories
                        caloriesCount = caloriesCount + 500;
                        break;
                    case "tomato sauce"://150 calories
                        caloriesCount = caloriesCount + 150;
                        break;
                    case "salami"://600 calories
                        caloriesCount = caloriesCount + 600;
                        break;
                    case "pepper"://50 calories
                        caloriesCount = caloriesCount + 50;
                        break;

                }
                
            }
            Console.WriteLine($"Total calories: {caloriesCount}");
        }
    }
}
