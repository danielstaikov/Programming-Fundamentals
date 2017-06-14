using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string hours = Console.ReadLine();
            string minutes = Console.ReadLine();
            string time = hours + ":" + minutes;
            DateTime tm = Convert.ToDateTime(time);
            DateTime answer = tm.AddMinutes(30);
            Console.WriteLine(answer.ToString("H:mm"));
        }
    }
}
