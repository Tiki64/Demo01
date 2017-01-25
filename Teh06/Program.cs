using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double bensanhinta, bensanmaara;
            double hinta = 1.595;

            Console.WriteLine(" Anna matka kilometreina > ");
            matka = int.Parse(Console.ReadLine());

            bensanmaara = matka * 0.0702;
            Console.WriteLine(" Bensan kulutus on " + bensanmaara + " litraa.");

            bensanhinta = bensanmaara * 1.595;
            Console.WriteLine(" Bensan hinta on " + bensanhinta + " euroa");

        }
    }
}
