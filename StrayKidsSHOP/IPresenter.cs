using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StrayKidsSHOP
{
    internal interface IPresenter
    {
        void AddCategoriesToCombo(ComboBox combobox);

        void AddItemsAndDetailsToCombo(ComboBox comboboxItem, ComboBox comboboxDetails, string category);

        void AddItemsInfo(string category, string name, string details);

        void AddItemsInfo(string category, string name);

        void AddToCart(string category, string name);

        void AddToCart(string category, string name, string details);

        void DeleteFromCart(int i);
        void CountTotalAmount();
        bool LoginUser(string login, string password);

        bool SignUpUser(string name, string login, string password);








    }
}
