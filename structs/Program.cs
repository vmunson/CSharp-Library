using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = new Weather();

            today.Temperature = 90;
            today.IsCloudy = false;

            Console.WriteLine(today.Forcast(today.Temperature, today.IsCloudy));
        
        }
    }
}
