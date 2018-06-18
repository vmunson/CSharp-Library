using System;

namespace enums
{
    class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Months value= Months.June;

            switch (value)
            {
                case Months.January:
                case Months.February:
                case Months.December:
                Console.WriteLine("It's winter");
                break;
                case Months.March:
                case Months.April:
                case Months.May:
                Console.WriteLine("It's spring");
                break;
                case Months.June:
                case Months.July:
                case Months.August:
                Console.WriteLine("It's summer!");
                break;
                case Months.September:
                case Months.October:
                case Months.November:
                Console.WriteLine("It's fall");
                break;
                default:
                Console.WriteLine("It's a season");
                break;
            }
        }
    }
}
