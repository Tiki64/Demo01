using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna pisteet ");
                points[i] = int.Parse(Console.ReadLine());
            }
            int smallest_number = 999999999;
            int highest_number = 0;
            foreach (int value in points)
            {
                smallest_number = Math.Min(smallest_number, value);
                highest_number = Math.Max(highest_number, value);
            }
            int sum = points.Sum() - (smallest_number + highest_number);
            Console.WriteLine("Kokonaispisteet ovat " + sum);
        }
    }
}
