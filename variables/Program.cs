using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var myName = "Ginny";
            var myAge = 27;
            Console.WriteLine($"Hello, my name is {myName}. I am {myAge} years old.");
            Console.WriteLine($"{myName.Length}");

            string sentence = "Today is Monday";
            Console.WriteLine(sentence);
            sentence = sentence.Replace("Monday", "Thursday");
            Console.WriteLine(sentence);

            int integer = 42;
            float number = 1.33f;
            double bigNumber = 3.1131313d;
            decimal biggestNumber = 4.131313144444444m;
            int otherInteger = 22;
            Console.WriteLine(integer - otherInteger);
            Console.WriteLine($"The numba rumba {integer}, {number}, {bigNumber}, {biggestNumber}");

            bool isTrue = true;
        }
    }
}
