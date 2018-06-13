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

            string[] teams = {"colts", "texans", "titans", "jaguars"};

            foreach(string team in teams) {
                Console.WriteLine(team);
            }
            
        }
    }
}
