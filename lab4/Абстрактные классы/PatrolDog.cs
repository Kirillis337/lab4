using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class PatrolDog : Pet
    {
        public override void voice()
        {
            Console.WriteLine("Злой гав!");
        }
    }
}
