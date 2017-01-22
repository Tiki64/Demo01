using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh05
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, seconds, hours, minutes;



            Console.WriteLine(" Syota sekunnit numerona ");
            total = int.Parse(Console.ReadLine());
            minutes = total / 60;
            seconds = total % 60;
            hours = minutes / 60;
            minutes = minutes % 60;

            Console.WriteLine(total + " sekunttia on " + hours + " tuntia " + minutes + " minuuttia " + seconds +  " sekuntia ");


        }


    }
}
