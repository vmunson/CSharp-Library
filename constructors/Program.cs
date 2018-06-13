using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ginny = new Student("Ginny", "Munson");
            Student pam = new Student("Pam", "Jones", 4, 10);

            Console.WriteLine($"{ginny.LastName} {pam.Age}");
        }
    }
}
