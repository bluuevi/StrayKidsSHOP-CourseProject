using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayKidsSHOP
{
    internal class Shop //класс магазин
    {
        internal User User { get; set; }

        internal Cart Cart { get; set; }

        internal ItemsBase ItemsBase { get; set; }

        internal Shop() //пользователь добавляется только при регистрации или авторизации
        {
            ItemsBase = ItemsBase.GetInstance();
            Cart = new Cart();
           
        }

        //метод оплаты
        internal bool Pay(bool usePoints)
        {
            //если используем не используем балллы
            if (!usePoints)
                if (Cart.TotalAmount > User.Money) //не хватает денег
                {
                    return false;
                }
                else //хватает денег
                {
                    User.Money -= Cart.TotalAmount; //вычитание денег у пользователя
                    User.Points += Cart.TotalAmount / 100; //добавление баллов пользователю 
                    User.Pay(); //запись в файл новой информации о деньгих и баллах
                    Cart.CartList.Clear();

                    return true;
                }


            //если используем баллы
            if (usePoints)
                if (User.Points >= Cart.TotalAmount) //если баллов больше суммы
                {
                    //оплата только баллами
                    User.Points -= Cart.TotalAmount;
                    User.Points += Cart.TotalAmount / 100;
                    User.Pay();
                    Cart.CartList.Clear();

                    return true;
                }
                else //оплата и баллами и деньгами
                {
                    if ((User.Money + User.Points) >= Cart.TotalAmount) //хватает денег и баллов
                    {
                        User.Money -= (Cart.TotalAmount - User.Points);
                        User.Points = 0;
                        User.Points += Cart.TotalAmount / 100;
                        User.Pay();
                        Cart.CartList.Clear();

                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            else return false;

        }


    }
}
