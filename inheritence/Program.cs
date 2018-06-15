using System;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Sloth latte = new Sloth();

            latte.HasFur = true;
            latte.NumberOfToes = 2;
            
            Dog fiesta = new Dog();

            fiesta.Breed = "Yellow Lab";
            fiesta.NumberOfLegs = 4;

            Console.WriteLine($"{latte.HasFur} {fiesta.Breed} {fiesta.GetMad()} {latte.StateType()}");
        }
    }
}
