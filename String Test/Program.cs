using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Test
{
    class Program
    {
        static void Main(string[] args)
        {


            // The input string.
            string input = "http://site.com";

            // Test these endings.
            string[] arr = new string[]
            {
            ".net",
            ".com",
            ".org"
            };

            // Loop through and test each string.
            foreach (string s in arr)
            {
                if (input.EndsWith(s))
                {
                    Console.WriteLine(s);
                    return;
                }
    }
}
