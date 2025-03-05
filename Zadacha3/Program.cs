using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Vavedi godina: ");
                int year = int.Parse(Console.ReadLine());

                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("Visokosna godina!");
                }
                else
                {
                    Console.WriteLine("Ne e visokosna godina!");
                }
            
            
        }
    }
}
