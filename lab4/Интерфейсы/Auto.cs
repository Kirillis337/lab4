using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Auto
    {
        protected int passangerplace; // места под пасажиров
        protected int cargoplace; // места под багаж
        protected string name;

        public Auto(int passangerplace, int cargoplace)
        {
            this.passangerplace = passangerplace;
            this.cargoplace = cargoplace;

        }
    }
}
