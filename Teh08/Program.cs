﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Anna kolme numeroa ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] arrayNumbers = { a, b, c };
            int arrayNumbersBiggest = arrayNumbers.Max();
            Console.WriteLine(arrayNumbersBiggest);
        }
    }
}
