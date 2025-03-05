using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Vavedi chislo: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Chisloto otgovarq na usloviqta!");
                }
                else
                {
                    Console.WriteLine("Chisloto ne otgovarq na usloviqta!");
                }
        }
    }
}
