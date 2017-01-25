using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko1 = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < taulukko1.Length; i++)
            {
                if (taulukko1[i] % 2 == 0)

                {
                    Console.WriteLine("HEP");
                }
            }


        }
    }
}
