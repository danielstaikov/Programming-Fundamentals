using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            //	A noun that ends in y – remove the y and add ies
            //	A noun that ends in o, ch, s, sh, x or z – add es at the end of the word
            //	In all other cases – just add s at the end

            bool endsInY = noun.EndsWith("y");
            bool endsInMulti = noun.EndsWith("o")|| noun.EndsWith("ch")|| noun.EndsWith("sh")|| noun.EndsWith("s")|| noun.EndsWith("x")|| noun.EndsWith("z");
            if (endsInY)
            {

                string result = noun.TrimEnd('y');
                Console.WriteLine(result + "ies");
            }
            else if (endsInMulti)
            {

                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }

        }
    }
}
