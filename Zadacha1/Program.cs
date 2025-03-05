using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Vavedi chislo: ");
                double number = double.Parse(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("Chisloto e polozhitelno!");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Chisloto e otritsatelno!");
                }
                else
                {
                    Console.WriteLine("Chisloto e 0!");
                }
        }
    }
}
