using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;


            Console.WriteLine(" Syota ensimmainen numerosi ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Syota toinen numerosi ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Syota kolmas numerosi ");
            number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum is: " + (number1 + number2 + number3));
        }
    }
}
