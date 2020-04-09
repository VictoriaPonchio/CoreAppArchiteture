using CoreAppArchiteture.Core;
using CoreAppArchiteture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppArchiteture.WebUI.Test
{
    public class ShoppingListDTO : BaseEntity
    {     
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public static ShoppingListDTO FromShoppingList(ShoppingList item)
        {
            return new ShoppingListDTO()
            {
                ID = item.ID,
                Title = item.Title,
                Description = item.Description
            };
        }
    }
}
