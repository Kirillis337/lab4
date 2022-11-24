using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace lab4
{
    abstract class Pet
    {
        //name, age, hungry(хочет есть) и абстрактный метод voice(голос). 
        protected string name;
        protected int age;
        protected bool hungry;
        public Pet()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            while (!Regex.IsMatch(name, @"^[А-Яа-я]+$"))
            {
                Console.Write("Введите корректное имя: ");
                name = Console.ReadLine();
            }
            Console.Write("Введите возраст: ");
            while (!(int.TryParse(Console.ReadLine(), out age) && age > 0))
                Console.Write("Введите корректный возраст: ");
            Console.Write("Голоден ли питомец(да/нет): ");

            string hngr = Console.ReadLine();
            while (!(hngr == "да" || hngr == "нет"))
            {
                Console.Write("Голоден ли питомец(да/нет): ");
                hngr = Console.ReadLine();
            }
            if (hngr == "да")
                hungry = true;
            else
                hungry = false;
        }
        public abstract void voice();
    }
}
