using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StrayKidsSHOP
{
    internal interface IView //интерфейс представления
    {

        //метод добавления элемента в комбобокс
         void AddTextInCombo(string text, ComboBox comboBox);

        //метод добавления информации о товаре (картинка, описание, цена) в форму
         void AddPictureDescriptionPrice(string picture, string description, string price);

        //метод добавления товара в листбокс корзины
        void AddToCart(string item);

        //метод удаления товара из листбокса корзины
        void DeleteFromCart(int i);

        //метод показа стоимости корзины 
        void ShowTotalAmount(string total);

        //метод успешного входа/регистрации, выводит в форму информацию о пользвателе
         void LoginOrSignUpSuccesful(string name, string money, string points);

        //метод оплаты
         void Pay(string money, string points);





    }
}
