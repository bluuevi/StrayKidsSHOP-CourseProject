using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StrayKidsSHOP
{
    internal class Presenter : IPresenter
    {

        internal IView view; //объект представления
        internal Shop shop; //объект магазина

        public Presenter(IView View)
        {
            this.view = View; //агрегация
            shop = new Shop(); //композиция

        }

        //метод для добавления категорий товаров из модели в представление
        public void AddCategoriesToCombo(ComboBox combobox)
        {
            for (int i = 0; i < shop.ItemsBase.Categories.Count; i++)
            {
                view.AddTextInCombo(shop.ItemsBase.Categories[i], combobox);
            }
        }

        //метод добавления названий и доп. параметров о товарах выбранной категории из модели в представление
        public void AddItemsAndDetailsToCombo(ComboBox comboboxItem, ComboBox comboboxDetails, string category)
        {

            switch (category)
            {
                //если  категория лайтстик
                case "Lightstick":

                    for (int i = 0; i < shop.ItemsBase.Lightsticks.Count; i++)
                    {
                        bool repeat = false; //повторяющиеся названия
                        for (int j = 0; j < comboboxItem.Items.Count; j++)
                        {
                            if (shop.ItemsBase.Lightsticks[i].Name == Convert.ToString(comboboxItem.Items[j])) //такое название уже есть
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false) //если такого названия нет в комбобоксе
                        {
                            //добавляет название
                            view.AddTextInCombo(shop.ItemsBase.Lightsticks[i].Name, comboboxItem);

                        }
                    }
                    break;

                //если категория лайтстик
                case "Albums":
                    //так же как и лайтстик
                    for (int i = 0; i < shop.ItemsBase.Albums.Count; i++)
                    {
                        bool repeat = false;
                        for (int j = 0; j < comboboxItem.Items.Count; j++)
                        {
                            if (shop.ItemsBase.Albums[i].Name == Convert.ToString(comboboxItem.Items[j]))
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false)
                        {
                            view.AddTextInCombo(shop.ItemsBase.Albums[i].Name, comboboxItem);

                        }

                    }
                    //добавление типов альбомов, потакой же логике, как и названий
                    for (int i = 0; i < shop.ItemsBase.Albums.Count; i++)
                    {
                        bool repeat = false;
                        for (int j = 0; j < comboboxDetails.Items.Count; j++)
                        {
                            if (shop.ItemsBase.Albums[i].Type == Convert.ToString(comboboxDetails.Items[j]))
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false)
                        {
                            view.AddTextInCombo(shop.ItemsBase.Albums[i].Type, comboboxDetails);

                        }

                    }

                    break;
                    //если категория карточки
                case "Cards":
                    //так же, как и альбомы
                    for (int i = 0; i < shop.ItemsBase.Cards.Count; i++)
                    {
                        bool repeat = false;
                        for (int j = 0; j < comboboxItem.Items.Count; j++)
                        {
                            if (shop.ItemsBase.Cards[i].Name == Convert.ToString(comboboxItem.Items[j]))
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false)
                        {
                            view.AddTextInCombo(shop.ItemsBase.Cards[i].Name, comboboxItem);

                        }
                    }

                    for (int i = 0; i < shop.ItemsBase.Cards.Count; i++)
                    {
                        bool repeat = false;
                        for (int j = 0; j < comboboxDetails.Items.Count; j++)
                        {
                            if (shop.ItemsBase.Cards[i].Person == Convert.ToString(comboboxDetails.Items[j]))
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false)
                        {
                            view.AddTextInCombo(shop.ItemsBase.Cards[i].Person, comboboxDetails);

                        }
                    }
                    break;

                case "SKZOO": //если категория SKZOO
                    //так же, как выше
                    for (int i = 0; i < shop.ItemsBase.SKZOO.Count; i++)
                    {
                        bool repeat = false;
                        for (int j = 0; j < comboboxItem.Items.Count; j++)
                        {
                            if (shop.ItemsBase.SKZOO[i].Name == Convert.ToString(comboboxItem.Items[j]))
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false)
                        {
                            view.AddTextInCombo(shop.ItemsBase.SKZOO[i].Name, comboboxItem);

                        }
                    }

                    for (int i = 0; i < shop.ItemsBase.SKZOO.Count; i++)
                    {
                        bool repeat = false;
                        for (int j = 0; j < comboboxDetails.Items.Count; j++)
                        {
                            if (shop.ItemsBase.SKZOO[i].Clothes == Convert.ToString(comboboxDetails.Items[j]))
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false)
                        {
                            view.AddTextInCombo(shop.ItemsBase.SKZOO[i].Clothes, comboboxDetails);

                        }
                    }
                    break;

            }



        }

        //добавление информации о выбранном товаре (описание, картинка, цена) из модели в представление
        public void AddItemsInfo(string category, string name, string details) //перегрузка метода для тех товаров, у которых есть доп параметры
        {
            switch (category)
            {


                case "Albums":

                    for (int i = 0; i < shop.ItemsBase.Albums.Count; i++)
                    {


                        if ((shop.ItemsBase.Albums[i].Name == name) && (shop.ItemsBase.Albums[i].Type == details))
                        {
                            view.AddPictureDescriptionPrice(shop.ItemsBase.Albums[i].PicturePath, shop.ItemsBase.Albums[i].Description, Convert.ToString(shop.ItemsBase.Albums[i].Price));
                        }

                    }

                    break;

                case "Cards":

                    for (int i = 0; i < shop.ItemsBase.Cards.Count; i++)
                    {


                        if ((shop.ItemsBase.Cards[i].Name == name) && (shop.ItemsBase.Cards[i].Person == details))
                        {
                            view.AddPictureDescriptionPrice(shop.ItemsBase.Cards[i].PicturePath, shop.ItemsBase.Cards[i].Description, Convert.ToString(shop.ItemsBase.Cards[i].Price));
                        }

                    }

                    break;

                case "SKZOO":

                    for (int i = 0; i < shop.ItemsBase.SKZOO.Count; i++)
                    {


                        if ((shop.ItemsBase.SKZOO[i].Name == name) && (shop.ItemsBase.SKZOO[i].Clothes == details))
                        {
                            view.AddPictureDescriptionPrice(shop.ItemsBase.SKZOO[i].PicturePath, shop.ItemsBase.SKZOO[i].Description, Convert.ToString(shop.ItemsBase.SKZOO[i].Price));
                        }

                    }

                    break;


            }


        }
        public void AddItemsInfo(string category, string name)//перегрузка метода для тех товаров, у которых нет доп. параметров
        {
            switch (category)
            {
                case "Lightstick":

                    for (int i = 0; i < shop.ItemsBase.Lightsticks.Count; i++)
                    {


                        if (shop.ItemsBase.Lightsticks[i].Name == name)
                        {
                            view.AddPictureDescriptionPrice(shop.ItemsBase.Lightsticks[i].PicturePath, shop.ItemsBase.Lightsticks[i].Description, Convert.ToString(shop.ItemsBase.Lightsticks[i].Price));
                        }

                    }

                    break;



            }



        }

        //метод добавления товара в корзину
        public void AddToCart(string category, string name, string details) //перегрузка метода для тех товаров, у которых есть доп. параметры 
        {

            switch (category)
            {
                case "Albums":

                    for (int i = 0; i < shop.ItemsBase.Albums.Count; i++)
                    {


                        if ((shop.ItemsBase.Albums[i].Name == name) && (shop.ItemsBase.Albums[i].Type == details))
                        {
                            view.AddToCart("Album " + Convert.ToString(shop.ItemsBase.Albums[i].Name) + " " + Convert.ToString(shop.ItemsBase.Albums[i].Type) + "   Price: " + Convert.ToString(shop.ItemsBase.Albums[i].Price) + " rub");

                            shop.Cart.AddItem(shop.ItemsBase.Albums[i]);

                        }

                    }

                    break;


                case "Cards":

                    for (int i = 0; i < shop.ItemsBase.Cards.Count; i++)
                    {


                        if ((shop.ItemsBase.Cards[i].Name == name) && (shop.ItemsBase.Cards[i].Person == details))
                        {
                            view.AddToCart("Card " + Convert.ToString(shop.ItemsBase.Cards[i].Name) + " " + Convert.ToString(shop.ItemsBase.Cards[i].Person) + "  Price: " + Convert.ToString(shop.ItemsBase.Cards[i].Price) + " rub");

                            shop.Cart.AddItem(shop.ItemsBase.Cards[i]);

                        }

                    }

                    break;


                case "SKZOO":

                    for (int i = 0; i < shop.ItemsBase.SKZOO.Count; i++)
                    {


                        if ((shop.ItemsBase.SKZOO[i].Name == name) && (shop.ItemsBase.SKZOO[i].Clothes == details))
                        {
                            view.AddToCart("SKZOO " + Convert.ToString(shop.ItemsBase.SKZOO[i].Name) + " " + Convert.ToString(shop.ItemsBase.SKZOO[i].Clothes) + "  Price: " + Convert.ToString(shop.ItemsBase.SKZOO[i].Price) + " rub");

                            shop.Cart.AddItem(shop.ItemsBase.SKZOO[i]);

                        }

                    }

                    break;


            }


        }
        public void AddToCart(string category, string name) //перегрузка метода для тех товаров, у которых нет доп. параметров
        {

            switch (category)
            {
                case "Lightstick":

                    for (int i = 0; i < shop.ItemsBase.Lightsticks.Count; i++)
                    {


                        if (shop.ItemsBase.Lightsticks[i].Name == name)
                        {
                            view.AddToCart("Lightstick " + Convert.ToString(shop.ItemsBase.Lightsticks[i].Name) + "  Price: " + Convert.ToString(shop.ItemsBase.Lightsticks[i].Price) + " rub");

                            shop.Cart.AddItem(shop.ItemsBase.Lightsticks[i]);

                        }

                    }

                    break;


            }

        }

        //метод удаления товара из корзины
        public void DeleteFromCart(int i) 
        {
            view.DeleteFromCart(i);

            shop.Cart.CartList.RemoveAt(i);
        }

        //метод расчета стоимости товаров в корзине
        public void CountTotalAmount()
        {
            shop.Cart.CountTotalAmount();
            view.ShowTotalAmount(shop.Cart.TotalAmount.ToString());
        }

        //метод авторизации пользователя 
        public bool LoginUser(string login, string password)
        {
            shop.User = User.LoginUser(login, password);
            if (shop.User != null)
            {

                view.LoginOrSignUpSuccesful(shop.User.Name, shop.User.Money.ToString(), shop.User.Points.ToString());
                return true;
            }
            else return false;
        }

        //метод регистрации пользователя
        public bool SignUpUser(string name, string login, string password)
        {
            shop.User = User.SignupUser(name, login, password);
            if (shop.User != null)
            {

                view.LoginOrSignUpSuccesful(shop.User.Name, shop.User.Money.ToString(), shop.User.Points.ToString());
                return true;
            }
            else return false;

        }

        //метод оплаты
        public bool Pay(bool usePoints)
        {

            if (!shop.Pay(usePoints))
            {
                return false;
            }
            else
            {

                view.Pay(shop.User.Money.ToString(), shop.User.Points.ToString());
                return true;
            }

        }

    }
}
