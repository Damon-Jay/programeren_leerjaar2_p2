using System;
using System.Collections.Generic;
using System.Text;

namespace PROG01
{
    class ManaPotion : Item
    {
        private int mana = 20;
        public ManaPotion(string name, string description) : base(name)
        {
        }

        public override void Use()
        {
            Console.WriteLine($"You used {Name} and heal for {mana}.");
        }

    }
}