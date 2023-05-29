using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace StrayKidsSHOP
{
    public partial class skzShopForm : Form, IView //представление в виде формы
    {

        IPresenter Presenter; 

        public skzShopForm()
        {
            InitializeComponent();

            Presenter = new Presenter(this); //композиция
            //при загрузке формы формы заполнение комбобоксов информацией
            Presenter.AddCategoriesToCombo(comboCategory);
            comboCategory.SelectedIndex = 0;
            Presenter.AddItemsAndDetailsToCombo(comboBoxItem, comboDetails, comboCategory.Text);
            comboBoxItem.SelectedIndex = 0;

            if (comboDetails.Visible == false)
            {
                Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text);
            }
            else Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);
            //настройка видимости элементов
            panelEmptyCart.Visible = true;
            buttonDeleteItem.Visible = false;
            buttonBuy.Visible = false;
            labelTotalText.Visible = false;
            labelTotalAmount.Visible = false;
            panelLogin.Visible = false;
            panelSignup.Visible = false;
            panelPay.Visible = false;
            pictureBoxPhotos.Visible = true;
            pictureBoxPhotos.Image = Image.FromFile("1.jpg");

        }

        //МЕТОДЫ ПРЕДСТАВЛЕНИЯ 

        //метод добавления элемента в комбобокс
        public void AddTextInCombo(string text, ComboBox comboBox)
        {
            comboBox.Items.Add(text);
        }

        //метод добавления информации о товаре (картинка, описание, цена) в форму
        public void AddPictureDescriptionPrice(string picture, string description, string price)
        {
            richDescription.Text = description;
            pictureBoxItem.Image = Image.FromFile(picture);
            labelPrice.Text = price;

        }

        //метод добавления товара в листбокс корзины
        public void AddToCart(string item)
        {

            listBoxCart.Items.Add(item);
        }

        //метод удаления товара из листбокса корзины
        public void DeleteFromCart(int i)
        {

            listBoxCart.Items.RemoveAt(i);

        }

        //метод показа стоимости корзины 
        public void ShowTotalAmount(string total)
        {
            labelTotalAmount.Text = total;
        }

        //метод успешного входа/регистрации, выводит в форму информацию о пользвателе
        public void LoginOrSignUpSuccesful(string name, string money, string points)
        {
            //настройка видимости и изменение картинки
            panelLogin.Visible = false;
            panelSignup.Visible = false;
            panelPay.Visible = true;
            pictureBoxPhotos.Visible=true;
            pictureBoxPhotos.Image = Image.FromFile("2.jpg");

            labelWelcome.Text += name;
            labelMoney.Text = money;
            labelPoints.Text = points;
        }

        //метод оплаты
        public void Pay(string money, string points)
        {
           //очистка значений в магазине и изменение денег пользователя
            listBoxCart.Items.Clear(); 
            labelTotalAmount.Text = null;
            labelMoney.Text=money;
            labelPoints.Text=points;
            panelEmptyCart.Visible = true;
            MessageBox.Show("Your order is accepted!! \nOur manager will contact you <3");
        }




        //ОБРАБОТКА СОБЫТИЙ ФОРМЫ

        private void buttonCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //переключение между панелями входа и регистрации
        private void labelLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSignup.Visible = false;
          
        }
        private void label_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSignup.Visible = true;

        }


        //при изменении категории очищаются комбобоксы товара и подробностей
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //при изменении категории очищаются комбобоксы товара и подробностей
            comboBoxItem.Items.Clear();
            comboDetails.Items.Clear();

            //добавляются товары и подробности соответствующей категории
            Presenter.AddItemsAndDetailsToCombo(comboBoxItem, comboDetails, comboCategory.Text);
            comboBoxItem.SelectedIndex = 0;

            if (comboCategory.SelectedIndex == 0)
            {
                comboDetails.Visible = false;
            }
            else
            {
                comboDetails.Visible = true;
                comboDetails.SelectedIndex = 0;
            }

            if (comboDetails.Visible == false) 
            {
                Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text); //если у товара нет подробностей
            }
            else Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text); //если есть

        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)//при изменении выбранного товара
        {
            //меняется картика описание и цена
            if (comboDetails.Visible == false)
            {
                Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text);
            }
            else Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);
        }

        private void comboDetails_SelectedIndexChanged(object sender, EventArgs e) //при изменении подробностей
        {
            Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text); //меняется картинка и иногда описание и цена
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            //настройка видимости элементов
            if ((panelPay.Visible == true) || (panelLogin.Visible == true) || (panelSignup.Visible == true))
            {
                buttonBuy.Visible = false;
            }
            else
            {
                buttonBuy.Visible = true;
            }
            buttonDeleteItem.Visible = true;
            labelTotalText.Visible = true;
            labelTotalAmount.Visible = true;
            panelEmptyCart.Visible = false;



            if (comboDetails.Visible == false) //если у товара нет подробностей
            {
                Presenter.AddToCart(comboCategory.Text, comboBoxItem.Text); //добавление в корзину
            }
            //если есть
            else Presenter.AddToCart(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);

            Presenter.CountTotalAmount(); //расчет стоимости корзины

        }

        private void buttonDeleteItem_Click(object sender, EventArgs e) //удаление товара из корзины
        {


            if (listBoxCart.SelectedIndex != -1) //если товар выбран
            {
                Presenter.DeleteFromCart(listBoxCart.SelectedIndex);
                Presenter.CountTotalAmount();
            }
            //иначе 
            else MessageBox.Show("Choose item please!!");


            if (listBoxCart.Items.Count == 0) //если в корзине нет товаров меняем видимость соотв элементов
            {
                buttonBuy.Visible = false;
                labelTotalText.Visible = false;
                labelTotalAmount.Visible = false;
                panelEmptyCart.Visible = true;

            }

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            //открываются панели входа/регистрации
            buttonBuy.Visible = false;
            pictureBoxPhotos.Visible = false;
            panelLogin.Visible = true;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((textBoxLogLogin.Text != "") && (textBoxLogPassword.Text != "")) //если поля не пустые
            {

                if (!Presenter.LoginUser(textBoxLogLogin.Text, textBoxLogPassword.Text)) //вход
                    MessageBox.Show("Login failed :(");

             
            }
            else MessageBox.Show("Please fill in the fields!");

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {

            if ((textBoxSignLogin.Text !="" ) && (textBoxSignPassword.Text != "") && (textBoxName.Text != "")) //если поля не пустые
            {

                if (!Presenter.SignUpUser(textBoxName.Text, textBoxSignLogin.Text, textBoxSignPassword.Text)) //регистрация
                    MessageBox.Show("Sign up failed :(");
            }
            else MessageBox.Show("Please fill in the fields!");

           

        }

       
        private void buttonPay_Click(object sender, EventArgs e) //оплата
        {
           if (! Presenter.Pay(checkBoxPoints.Checked))
                MessageBox.Show("You haven't enough money :("); //если неудачная

        }

        //запрет ввода пробелов в текстбоксах
        private void textBoxLogLogin_TextChanged(object sender, EventArgs e) 
        {
            if (textBoxLogLogin.Text.IndexOf(' ') > -1)
            {
                textBoxLogLogin.Text = "";
            }
        }
        private void textBoxLogPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogPassword.Text.IndexOf(' ') > -1)
            {
                textBoxLogPassword.Text = "";
            }
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.IndexOf(' ') > -1)
            {
                textBoxName.Text = "";
            }
        }
        private void textBoxSignLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSignLogin.Text.IndexOf(' ') > -1)
            {
                textBoxSignLogin.Text = "";
            }
        }
        private void textBoxSignPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSignPassword.Text.IndexOf(' ') > -1)
            {
                textBoxSignPassword.Text = "";
            }
        }
       
        private void tabControlShopAndCart_SelectedIndexChanged(object sender, EventArgs e)//при изменении вкладки
        {
            if ((panelPay.Visible == true) || (panelLogin.Visible == true) || (panelSignup.Visible == true)) //если открыта одна из панелей вход, регистрация, оплата
            {
                buttonBuy.Visible = false; //кнопка купить (ведущая на панель входа) отсутствует
            }
            else
            {
                buttonBuy.Visible = true;
            }
        }
    }
   
}
