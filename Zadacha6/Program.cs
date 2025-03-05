using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("--------------------------");
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{i} x {y} = {i * y}");
                }
            }
        }
    }
}
