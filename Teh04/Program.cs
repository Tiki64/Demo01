using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;


            Console.WriteLine(" Syota ikäsi numerona ");
            number1 = int.Parse(Console.ReadLine());

            if (number1 < 18)
            {
                Console.WriteLine("alaikainen");
            }

            else if (number1 >= 18 && number1 <= 65)
            {
                Console.WriteLine("aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }

        }
    }
}
