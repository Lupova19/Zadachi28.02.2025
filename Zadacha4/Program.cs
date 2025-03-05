using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Vavedi n: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 1)
                {
                    Console.WriteLine("Vavedi polozhitelno chislo!");
                    return;
                }

                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"Suma: {sum}");
            
        }
    }
}
