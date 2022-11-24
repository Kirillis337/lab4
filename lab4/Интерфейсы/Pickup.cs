using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Pickup : Auto, IAuto
    {
        public Pickup(int passangerplace, int cargoplace) :base( passangerplace, cargoplace)
        {
            name = GetType().Name;
        }
        //this.name=GetType.Name;
        public void CargoAuto()
        {
            Console.WriteLine($"{name} перевозит {cargoplace} кг рыбов");
        }
        public void PassangersAuto()
        {
            Console.WriteLine($"{name} перевозит {passangerplace} рыбаков");
        }
    }
}
