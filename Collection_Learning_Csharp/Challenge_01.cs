using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Learning_Csharp
{
    struct Item
    {
        string mName;
        double mPrice;
        int mQty;

        public Item(string n, double p, int q)
        {
            mName = n;
            mPrice = p;
            mQty = q;
        }

        public string Name { get => mName; set => mName = value; }
        public double Price { get => mPrice; set => mPrice = value; }
        public int Qty { get => mQty; set => mQty = value; }
    }
    internal class Challenge_01
    {
        List<Item> items;
        public Challenge_01()
        {
            items =  new List<Item>();


        }


        void Display()
        {
            foreach (Item item in items)
            {
                Console.WriteLine("Item: {0, 10}, Price: {1:C}, Quantity: {2}", item.Name, item.Price, item.Qty);
            }
            Console.WriteLine("==========================");
        }


        public void Solve()
        {
            items.Add(new Item("Apple", 0.95, 6));
            items.Add(new Item("Milk", 2.25, 1));
            items.Add(new Item("Sugar", 1.75, 2));
            items.Add(new Item("Bread", 3.25, 1));
            items.Add(new Item("Butter", 4.95, 1));
            items.Add(new Item("Cookies", 0.50, 4));
            items.Add(new Item("Oranges", 0.65, 5));
            items.Add(new Item("Chicken", 8.95, 1));

            Display();
        }
    }
}
