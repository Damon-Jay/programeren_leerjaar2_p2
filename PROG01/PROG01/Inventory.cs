using System;
using System.Collections.Generic;
using System.Text;

namespace PROG01
{
    class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public void Additem(Item item)
        {
            _items.Add(item);
        }

        public List<Item> GetItems()
        {
            return _items;
        }

        public int Length()
        {
            return _items.Count;
        }
    }
}