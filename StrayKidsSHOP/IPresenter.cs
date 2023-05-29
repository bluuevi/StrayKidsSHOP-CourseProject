using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StrayKidsSHOP
{
    internal interface IPresenter //интерфейс презентера 
    {

        //метод для добавления категорий товаров из модели в представление
        void AddCategoriesToCombo(ComboBox combobox);

        //метод добавления названий и доп. параметров о товарах выбранной категории из модели в представление
        void AddItemsAndDetailsToCombo(ComboBox comboboxItem, ComboBox comboboxDetails, string category);

        //добавление информации о выбранном товаре (описание, картинка, цена) из модели в представление
        void AddItemsInfo(string category, string name);//перегрузка метода для тех товаров, у которых нет доп. параметров
        void AddItemsInfo(string category, string name, string details); //перегрузка метода для тех товаров, у которых есть доп. параметры

        //метод добавления товара в корзину
        void AddToCart(string category, string name); //перегрузка метода для тех товаров, у которых нет доп. параметров
        void AddToCart(string category, string name, string details); //перегрузка метода для тех товаров, у которых есть доп. параметры

        //метод удаления товара из корзины
        void DeleteFromCart(int i);

        //метод расчета стоимости товаров в корзине
        void CountTotalAmount();

        //метод авторизации пользователя 
        bool LoginUser(string login, string password);

        //метод регистрации пользователя
        bool SignUpUser(string name, string login, string password);

        //метод оплаты
        bool Pay(bool useBonuses);

    }
}
