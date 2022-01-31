using PROG01;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROG01
{
    public class HealthPotion : Item
    {
        private int heal = 20;
        public HealthPotion(string name, string description) : base(name)
        {
        }

        public override void Use()
        {
            Console.WriteLine($"You used {Name} and heal for {heal}.");
        }

    }


}
