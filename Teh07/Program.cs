using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;

            Console.WriteLine(" Anna vuosi numerona ");
            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 4 == 0)
            {
                if (vuosi % 100 != 0)
                {

                    Console.WriteLine(" Vuosi on karkausvuosi.");
                }
                else if (vuosi % 400 == 0)
                {
                    Console.WriteLine("Vuosi on karkausuvosi.");
                } else
                {
                    Console.WriteLine("Vuosi ei ole karkausvuosi.");
                }
            } else 

            {
                Console.WriteLine(" Vuosi ei ole karkausvuosi");
            }
        }
    }
}
