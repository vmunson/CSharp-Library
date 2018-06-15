using System;

namespace getSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            example.Number = -2; // set { }
            Console.WriteLine(example.Number); // get { }
        }
    }
}
