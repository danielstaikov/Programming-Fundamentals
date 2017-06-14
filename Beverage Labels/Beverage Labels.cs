using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent100 = int.Parse(Console.ReadLine());
            int sugarContent100 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent100* volume*0.01}kcal, {sugarContent100*volume*0.01}g sugars");
        }
    }
}
