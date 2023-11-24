using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekaT2.Handlers
{
    public partial class ClickLayout 
    {
        public ClickLayout() { 
        
        }

        void MenuItem(object sender, EventArgs args)
        {
            MenuItem item = new MenuItem {  };
            item.Clicked += OnMenuItemClicked;
        }

        void OnMenuItemClicked(object sender, EventArgs args)
        {
            MenuItem menuItem = sender as MenuItem;

            var contextItem = menuItem.BindingContext;
        }
    }
}
