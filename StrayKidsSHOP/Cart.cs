using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayKidsSHOP
{
    internal class Cart
    {
        internal List<Item> CartList { get; set; }

        internal decimal TotalAmount { get; set; }

        internal Cart()
        {
            CartList = new List<Item>();
        }

        internal void AddItem(Item item)
        {
            CartList.Add(item);
        }

        internal void DeleteItem(Item item)
        {
            CartList.Remove(item);
        }

        internal decimal CountTotalAmount()
        {
            decimal totalAmount = 0;
            for (int i = 0; i < CartList.Count; i++)
            {
                totalAmount += CartList[i].Price;

            }

            this.TotalAmount = totalAmount;
            return totalAmount;
        }
    }
}
