using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
