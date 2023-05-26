using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrayKidsSHOP
{
    internal class Shop
    {
        public User User { get; set; }

        public Cart Cart { get; set; }

        public ItemsBase ItemsBase { get; set; }

        public Shop()
        {
          //  ItemsBase = new ItemsBase();
            Cart = new Cart();
           // User = new User();
        }



    }
}
