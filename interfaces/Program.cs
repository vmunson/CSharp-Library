using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample numbers = new Example();
            numbers.Num1 = 234;
            numbers.Num2 = 54;
            Console.WriteLine(numbers.addition());
        }
    }
}
