using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type -1 to exit");

            while(true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int value) || value == -1)
                    return;

                Console.WriteLine($"The sum of all digits of factorial { value } is { Factorial.SumOfDigits(value) }");
            }
        }
    }
}
