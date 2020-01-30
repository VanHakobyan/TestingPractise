using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    [Serializable]
    public class ShoppingCart : IDisposable
    {
        public List<Item> Items = new List<Item>();

        public int Count => Items.Count;

        public void Add(Item item)
        {
            Items.Add(item);
        }
        public void Dispose()
        {
            Items.Clear();
        }

        public void Remove(int i)
        {
            Items.RemoveAt(i);
        }
    }

    [Serializable]
    public class Item
    {
        public string Name { get; set; }
        public int Quantity  { get; set; }
    }
}
