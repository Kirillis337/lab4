using System;

namespace lab4
{
    class Program
    {
        static void Main()
        {
            //Fish fsh = new Fish();
            Sedan sedan = new Sedan(4, 10);
            Truck truck = new Truck(2, 100);
            Pickup pickup = new Pickup(2, 50);
            sedan.PassangersAuto();
            sedan.CargoAuto();
            truck.PassangersAuto();
            truck.CargoAuto();
            pickup.PassangersAuto();
            pickup.CargoAuto();

        }
    }
}
