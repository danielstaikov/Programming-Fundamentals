using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
                        var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var ID = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            var salaryTruncated = Math.Truncate(100*salary)/100;
 
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0}", ID.ToString("D8"));
            Console.WriteLine("Salary: {0}", salaryTruncated.ToString("F2"));
        }
    }
}
