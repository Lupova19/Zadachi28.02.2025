using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 

            while (true)
            {
                Console.Write("Vavedi chislo: ");
                int chislo = int.Parse(Console.ReadLine());

                if (chislo == 0) 
                {
                    break; 
                }
                sum += chislo; 
            }

            Console.WriteLine($"Sum:{sum}");
        }
    } 
}
