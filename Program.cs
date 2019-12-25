using System;
using static System.Console;

namespace property_tax_methods
{
    class Program
    {
        // declare class-level constants
        const double EXEMPTION = 25000,
                     MILLAGE_RATE = .01003,
                     INCREASE_RATE = .027;
        // declare class-level static variables
        static string propertyAddress;
        static double assessedValue,
                      valueAfterIncrease,
                      valueAfterExemption,
                      propertyTax;
        static void Main(string[] args)
        {
            Write("Enter property address: ");
            propertyAddress = ReadLine();
            assessedValue = ReadDouble("Enter assesed value:");
            WriteLine("{0}{1:C}", "Millage per $1000:", 1000 * MILLAGE_RATE);
        }
        static double ReadDouble(string label)
        {
            Write("{0} ", label);
            double number;
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("{0}{1} ", "Invalid input!\n", label);
                userInput = ReadLine();
            }
            return number;
        }
        static void CalculateTaxes()
        {
            valueAfterIncrease = assessedValue * (1 + INCREASE_RATE);
            valueAfterExemption = valueAfterIncrease - EXEMPTION;
            propertyTax = valueAfterExemption * MILLAGE_RATE;
        }
    }
}
