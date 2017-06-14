using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());//“Roundhouse kick”
            int goshosDamage = int.Parse(Console.ReadLine());//“Thunderous fist”
            int peshosHealth = 100;
            int goshosHealth = 100;
            int round = 0;

            while (peshosHealth!=0 && goshosHealth!=0)
            {

                round++ ;
                if (round%2!=0)
                {
                    goshosHealth = goshosHealth - peshosDamage;

                    if (goshosHealth <=0)
                      {
                          Console.WriteLine($"Pesho won in {round}th round.");
                          break;
                      }
                      else
                      {
                          Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                      }
                }
                else
                {

                    peshosHealth = peshosHealth - goshosDamage;
                    if (peshosHealth <= 0)
                      {
                          Console.WriteLine($"Gosho won in {round}th round.");
                          break;
                      }
                      else
                      {
                          Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                      }
                }





                if (round%3==0)
                {
                    peshosHealth = peshosHealth + 10;
                    goshosHealth = goshosHealth + 10;
                }             

            }

        }
    }
}
