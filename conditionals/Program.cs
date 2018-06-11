using System;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy = false;
            int uvIndex = 7;
            if (rainy)
            {
                Console.WriteLine("Rain, rain, go away");
            }else if (!rainy && uvIndex < 9)
            {
                Console.WriteLine("Let's go outside");
            }

            string weather = "rainy";
            switch (weather)
            {
                case "sunny":
                Console.WriteLine("Let's go outside");
                break;
                case "cloudy":
                Console.WriteLine("Meh, it's alright");
                break;
                case "rainy":
                Console.WriteLine("Go back to bed");
                break;
                default:
                Console.WriteLine("We can brave any type of weather");
                break;
            }
        }
    }
}
