using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingInventory
{
    internal class Inventory
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        public Inventory() { }

        public void add_item(string item, int amount = 1)
        {
            if (inventory.ContainsKey(item))
            { inventory[item] += amount; }
            else { inventory[item] = amount; }
        }

        public void remove_item(string item, int amount)
        {
            if (inventory.ContainsKey(item))
            {
                if (amount > inventory[item])
                {
                    inventory.Remove(item);
                }
                else
                {
                    inventory[item] -= amount;
                }
            }
        }
        public void print()
        {
            foreach(var key in inventory.Keys) 
                {
                Console.WriteLine(key + ":" + inventory[key].ToString());
            }
        }

        public int search(string name)
        {
            if (inventory.ContainsKey(name))
            {
                return inventory[name];
            }
            else
            {
                return 0;
            }
        }
    }
}
