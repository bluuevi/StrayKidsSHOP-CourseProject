using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayKidsSHOP
{
    //корзина
    internal class Cart 
    {
        //список товаров в корзине
        internal List<Item> CartList { get; set; }

        //стоимость товаров в корзине
        internal decimal TotalAmount { get; set; }

        //конструктор
        internal Cart()
        {
            CartList = new List<Item>();
        }

        //добавление товара в корзину
        internal void AddItem(Item item)
        {
            CartList.Add(item);
        }

        //удаление товара из корзины
        internal void DeleteItem(Item item)
        {
            CartList.Remove(item);
        }

        //метод расчета стоимости товаров в корзине
        internal decimal CountTotalAmount()
        {
            decimal totalAmount = 0;
            for (int i = 0; i < CartList.Count; i++)
            {
                totalAmount += CartList[i].Price;

            }

            this.TotalAmount = totalAmount; //заполнение свойства стоимости
            return totalAmount;
        }
    }
}
