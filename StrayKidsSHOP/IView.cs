using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StrayKidsSHOP
{
    internal interface IView
    {

         void AddTextInCombo(string text, ComboBox comboBox);

         void AddPictureDescriptionPrice(string picture, string description, string price);

        void AddToCart(string item);

        void DeleteFromCart(int i);

        void ShowTotalAmount(string total);




    }
}
