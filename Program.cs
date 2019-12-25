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
            CalculateTaxes();
            WriteLine(DisplayTaxes());
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
        static string DisplayTaxes()
        {
            string result = String.Format("\n****** Property Tax Assessment Table ******\n");
            // result += String.Format("* {0, 21}{1, 18:C} *\n", "Millage per $1000:", 1000 * MILLAGE_RATE);
            result += String.Format("* {0, 21}{1, 18} *\n", "Property Address:", propertyAddress);
            result += String.Format("* {0, 21}{1, 18:C} *\n", "Assessed Value:", assessedValue);
            result += String.Format("* {0, 21}{1, 18:C} *\n", "Value After Increase:", valueAfterIncrease);
            result += String.Format("* {0, 21}{1, 18:C} *\n", "Exemption:", EXEMPTION);
            result += String.Format("* {0, 21}{1, 18:C} *\n", "Taxable Value:", valueAfterExemption);
            result += String.Format("* {0, 21}{1, 18:C} *\n", "Property Tax:", propertyTax);
            result += String.Format("*******************************************\n");
            return result;
        }
    }
}
