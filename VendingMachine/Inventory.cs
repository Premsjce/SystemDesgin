using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface IInventory<T>
    {
        int GetQuantity(T item);
        void Add(T item);
        void Deduct(T item);
        bool HasItem(T item);
        void Clear();
        void Put(T item, int quantity);
    }

    /// <summary>
    /// An Adapter class over Dictionary to hold the item and cash inside the vending machine
    /// </summary>
    public class Inventory<T> : IInventory<T>
    {
        private Dictionary<T, int> inventory = new Dictionary<T, int>();

        public int GetQuantity(T item) => HasItem(item) ? inventory[item] : 0;

        public void Add(T item)
        {
            if (HasItem(item))
                inventory[item] = inventory[item] + 1;
            else
                inventory.Add(item, 1);
        }

        public void Deduct(T item)
        {
            if (HasItem(item))
                inventory[item] = inventory[item] - 1;
        }

        public bool HasItem(T item) => inventory.ContainsKey(item) ? true : false;

        public void Clear() => inventory.Clear();

        public void Put(T item, int quantity) => inventory.Add(item, quantity);
    }
}
