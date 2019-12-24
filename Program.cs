using System;
using static System.Console;

namespace property_tax_methods
{
    class Program
    {
        // declare class-level constants
        const double EXEMPTION = 25000,
                     MILLAGE_RATE = .01003,
                     INCREASE_RATE = 2.7;
        static void Main(string[] args)
        {
            WriteLine("{0}{1:C}", "Millage per $1000:", 1000 * MILLAGE_RATE);
        }
    }
}
