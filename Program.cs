using System;
using Game_RPG_OO;

namespace Game_RPG_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack());
            Console.WriteLine(hero.Attack());

        }
    }
}
