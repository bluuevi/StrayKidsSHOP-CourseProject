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
    public partial class skzShopForm : Form
    {
        ItemsBase itemsBase;
        public skzShopForm()
        {
            InitializeComponent();

            itemsBase = ItemsBase.GetInstance();
            comboCategory.SelectedIndex = 0;
            //comboBoxItem.SelectedIndex = 0;
           // comboDetails.SelectedIndex = 0;

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

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            richDescription.Text = itemsBase.Cards[21].Description;
            pictureBoxItem.Image = Image.FromFile(itemsBase.Cards[21].PicturePath);
            labelPrice.Text = itemsBase.Cards[21].Price.ToString() + itemsBase.Cards[21].Person.ToString();

        }
    }
}
