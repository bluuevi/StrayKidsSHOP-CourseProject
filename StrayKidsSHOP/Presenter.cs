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

        internal IView view;
        internal Shop shop;

        public Presenter(IView View)
        {
            this.view = View; //агрегация
            shop = new Shop(); //композиция

        }

        public void AddCategoriesToCombo(ComboBox combobox)
        {
            for (int i = 0; i < shop.ItemsBase.Categories.Count; i++)
            {
                view.AddTextInCombo(shop.ItemsBase.Categories[i], combobox);
            }
        }


        public void AddItemsAndDetailsToCombo(ComboBox comboboxItem, ComboBox comboboxDetails, string category)
        {

            switch (category)
            {
                case "Lightstick":

                    for (int i = 0; i < shop.ItemsBase.Lightsticks.Count; i++)
                    {
                        bool repeat = false;
                        for (int j = 0; j < comboboxItem.Items.Count; j++)
                        {
                            if (shop.ItemsBase.Lightsticks[i].Name == Convert.ToString(comboboxItem.Items[j]))
                            {
                                repeat = true;
                            }
                        }

                        if (repeat == false)
                        {
                            view.AddTextInCombo(shop.ItemsBase.Lightsticks[i].Name, comboboxItem);

                        }
                    }
                    break;

                case "Albums":
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

                case "Cards":
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

                case "SKZOO":
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


        public void AddItemsInfo(string category, string name, string details)
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

        public void AddItemsInfo(string category, string name)
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



        public void AddToCart(string category, string name, string details)
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


        public void AddToCart(string category, string name)
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




        public void DeleteFromCart(int i)
        {
            view.DeleteFromCart(i);

            shop.Cart.CartList.RemoveAt(i);
        }







        public void CountTotalAmount()

        {
            shop.Cart.CountTotalAmount();
            view.ShowTotalAmount(shop.Cart.TotalAmount.ToString());
        }



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


        public bool Pay(bool useBonuses)
        {
            if (!useBonuses)
                if (shop.Cart.TotalAmount > shop.User.Money)
                {
                    MessageBox.Show("You haven't enough money :(");
                    return false;
                }
                else
                {
                    shop.User.Money -= shop.Cart.TotalAmount;
                    shop.User.Points+=shop.Cart.TotalAmount/100;
                    view.Pay(shop.User.Money.ToString(), shop.User.Points.ToString());
                    shop.User.Pay();
                    shop.Cart.CartList.Clear();

                    return true;
                }



            if (useBonuses)
                if (shop.User.Points > shop.Cart.TotalAmount)
                {
                    shop.User.Points -= shop.Cart.TotalAmount;
                    shop.User.Points += shop.Cart.TotalAmount / 100;
                    view.Pay(shop.User.Money.ToString(), shop.User.Points.ToString());
                    shop.User.Pay();
                    shop.Cart.CartList.Clear();

                    return true;
                }
                else
                {
                    if ((shop.User.Money - shop.User.Points) >= shop.Cart.TotalAmount)
                    {
                        shop.User.Money -= (shop.Cart.TotalAmount - shop.User.Points);
                        shop.User.Points = 0;
                        shop.User.Points += shop.Cart.TotalAmount / 100;
                        view.Pay(shop.User.Money.ToString(), shop.User.Points.ToString());
                        shop.User.Pay();
                        shop.Cart.CartList.Clear();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("You haven't enough points :(");
                        return false;
                    }

                }
            else return false;

            

        }



    }
}
