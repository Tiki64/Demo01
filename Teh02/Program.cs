using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Anna numero >");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out number);
            if (result == true)
            {
                switch (number)
                {
                    case 0: Console.WriteLine("Numero on 0"); break;
                    case 1: Console.WriteLine("0"); break;
                    case 2: Console.WriteLine("Yksi"); break;
                    case 3: Console.WriteLine("Yksi"); break;
                    case 4: Console.WriteLine("Kaksi"); break;
                    case 5: Console.WriteLine("Kaksi"); break;
                    case 6: Console.WriteLine("Kolme"); break;
                    case 7: Console.WriteLine("Kolme"); break;
                    case 8: Console.WriteLine("Neljä"); break;
                    case 9: Console.WriteLine("Neljä"); break;
                    case 10: Console.WriteLine("Viisi"); break;
                    case 11: Console.WriteLine("Viisi"); break;
                    case 12: Console.WriteLine("Viisi"); break;
                    default: Console.WriteLine("Joku muu luku"); break;
                }
                Console.ReadLine();
            }
        }
    }
}
