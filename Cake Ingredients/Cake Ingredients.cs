using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isNumberEven = true;
            string ingredient = Console.ReadLine();
            int number = 0;
            

                while (isNumberEven)
                {
                    number++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    ingredient = Console.ReadLine();
                    isNumberEven = ingredient != "Bake!";
                }



            Console.WriteLine($"Preparing cake with {number} ingredients.");
        }
    }
}
