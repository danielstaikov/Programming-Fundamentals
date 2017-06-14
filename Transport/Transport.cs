using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            //3 vehicles of capacity 4, 8 and 12
            double courses = Math.Ceiling((double)persons / 24);
            Console.WriteLine($"{courses:f0}");
        }
    }
}
