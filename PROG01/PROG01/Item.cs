using System;
using System.Collections.Generic;
using System.Text;

namespace PROG01
{
    public abstract class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }

        public abstract void Use();
        /*
        public abstract class Ability
        {
            public string Name { get; private set; }
            public string Description { get; private set; }

            protected Ability(string name, string description)
            {
                this.Name = name;
                this.Description = description;
            }
            public abstract void Use();

        }
       */
    }
}