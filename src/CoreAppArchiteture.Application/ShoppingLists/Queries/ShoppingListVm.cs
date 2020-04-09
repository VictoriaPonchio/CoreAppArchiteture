using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppArchiteture.Application.ShoppingLists.Queries
{
    public class ShoppingListVm
    {
        public IList<ShoppingListLookupDto> ShopingLists { get; set; }
    }
}
