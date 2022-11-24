using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Sedan : Auto, IAuto
    {
        public Sedan(int passangerplace, int cargoplace) : base(passangerplace, cargoplace)
        {
            name = GetType().Name;
        }
        public void CargoAuto()
        {
            Console.WriteLine($"{name} перевозит {cargoplace} кг картошки");
        }
        public void PassangersAuto()
        {
            Console.WriteLine($"{name} перевозит {passangerplace} пассажиров");
        }
    }
}
