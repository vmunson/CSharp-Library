using System;

namespace methodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player joe = new Player();
            joe.Points = 4;
            joe.Weapon = "mace";

            Console.WriteLine(joe.Attack());
            Console.WriteLine(joe.Attack(joe.Points));
            Console.WriteLine(joe.Attack(joe.Points, joe.Weapon));
        }
    }
}
