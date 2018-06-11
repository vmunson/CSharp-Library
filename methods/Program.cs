using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int Multiply(int numOne, int numTwo)
            {
                return numOne * numTwo;
            }
            Console.WriteLine(Multiply(5, 2));

            string FullName(string firstName, string lastName)
            {
                return $"{firstName} {lastName}";
            }
            Console.WriteLine(FullName("Ginny", "Munson"));

            Netflix newShow = new Netflix();
            Netflix newShowTwo = new Netflix();
            Netflix newShowThree = new Netflix();

            newShow.Name = "The Crown";
            newShow.Rating = 5;
            newShow.Genre = "Historical Drama";

            newShowTwo.Name = "Arrow";
            newShowTwo.Rating = 3;
            newShowTwo.Genre = "Superhero Drama";

            newShowThree.Name = "The Office";
            newShowThree.Rating = 5;
            newShowThree.Genre = "Comedy";

            

            Console.WriteLine(newShowTwo.getSuggestion());
        }
    }
}
