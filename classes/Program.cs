using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut myDonut = new Donut();
            Donut yourDonut = new Donut();
            Donut herDonut = new Donut();

            myDonut.Type = "Jelly Filled";
            myDonut.Filling = "Strawberry Jelly";

            yourDonut.Price = 2.50m;

            herDonut.isSpecial = false;

            Console.WriteLine($"{myDonut.Type} {yourDonut.Price} {herDonut.isSpecial}");

            Hotel hampton = new Hotel();

            hampton.RoomNumber = "B23";
            hampton.IsAvailable = true;
        }
    }
}
