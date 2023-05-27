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
    public partial class skzShopForm : Form, IView
    {

        IPresenter Presenter;

        public skzShopForm()
        {
            InitializeComponent();

            Presenter = new Presenter(this);
            Presenter.AddCategoriesToCombo(comboCategory);
            comboCategory.SelectedIndex = 0;
            Presenter.AddItemsAndDetailsToCombo(comboBoxItem, comboDetails, comboCategory.Text);
            comboBoxItem.SelectedIndex = 0;

            if (comboDetails.Visible == false)
            {
                Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text);
            }
            else Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);

            panelEmptyCart.Visible = false;
            buttonDeleteItem.Visible = false;
            buttonBuy.Visible = false;
            labelTotalText.Visible = false;
            labelTotalAmount.Visible = false;

        }



        public void AddTextInCombo(string text, ComboBox comboBox)
        {
            comboBox.Items.Add(text);
        }


        public void AddPictureDescriptionPrice(string picture, string description, string price)
        {
            richDescription.Text = description;
            pictureBoxItem.Image = Image.FromFile(picture);
            labelPrice.Text = price;

        }



        public void AddToCart(string item)
        {

            listBoxCart.Items.Add(item);
        }


        public void DeleteFromCart(int i)
        {

            listBoxCart.Items.RemoveAt(i);
           
        }



        public void ShowTotalAmount(string total)
        {
            labelTotalAmount.Text = total;
        }






        private void buttonCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void label_Click(object sender, EventArgs e)
        {
            panelSignup.BringToFront();
        }

       

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxItem.Items.Clear();
            comboDetails.Items.Clear();


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
                Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text);
            }
            else Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);

        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboDetails.Visible == false)
            {
                Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text);
            }
            else Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);
        }

        private void comboDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.AddItemsInfo(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {


            buttonBuy.Visible = true;
            buttonDeleteItem.Visible = true;
            labelTotalText.Visible = true;
            labelTotalAmount.Visible=true;
            panelEmptyCart.Visible = false;



            if (comboDetails.Visible == false)
            {
                Presenter.AddToCart(comboCategory.Text, comboBoxItem.Text);
            }
            else Presenter.AddToCart(comboCategory.Text, comboBoxItem.Text, comboDetails.Text);

            Presenter.CountTotalAmount();

        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {

            
            if (listBoxCart.SelectedIndex != -1)
            {
                Presenter.DeleteFromCart(listBoxCart.SelectedIndex);
                Presenter.CountTotalAmount();
            }
            else MessageBox.Show("Choose item please!!");


            if (listBoxCart.Items.Count == 0)
            {
                buttonBuy.Visible = false;
                buttonDeleteItem.Visible = false;
                labelTotalText.Visible=false;
                labelTotalAmount.Visible = false;
                panelEmptyCart.Visible = true;


            }

        }
    }
   
}
