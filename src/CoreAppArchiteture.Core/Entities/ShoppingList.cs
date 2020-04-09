using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreAppArchiteture.Core.Entities
{
    [Table("TB_SHOPPING_LIST")]
    public class ShoppingList : BaseEntity
    { 
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; }

        public long Amount { get; set; }

    }
}
