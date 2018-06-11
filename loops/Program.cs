using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;

            while (num > 0)
            {
                Console.WriteLine($"{num} is greater than 0");
                num -= 10;
            }

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i} is less than 11");
            }
        }
    }
}
