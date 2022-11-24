using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Truck : Auto, IAuto
    {
        public Truck(int passangerplace, int cargoplace) : base(passangerplace, cargoplace)
        {
            name = GetType().Name;
        }
        public void CargoAuto()
        {
            Console.WriteLine($"{name} перевозит {cargoplace} кг кирпичей");
        }
        public void PassangersAuto()
        {
            Console.WriteLine($"{name} перевозит {passangerplace} дальнобойщиков");
        }
    }
}
