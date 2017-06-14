using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char exception = char.Parse(Console.ReadLine());
            int n = (int)firstLetter;
            int m = (int)secondLetter;
            int ex = (int)exception;
            for (int i = n; i <= m; i++)
            {

                for (int j = n; j <= m; j++)
                {

                    for (int k = n; k <= m; k++)
                    {
                        if (ex!=i && ex!=j && ex!=k)
                        {


                            Console.Write((char)i);
                            Console.Write((char)j);
                            Console.Write((char)k);
                            Console.Write(" ");
                        }
                    }
                }
            }
           
        }
    }
}
