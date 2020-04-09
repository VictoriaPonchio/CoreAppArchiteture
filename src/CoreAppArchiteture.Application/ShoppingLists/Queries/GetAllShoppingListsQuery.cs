using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppArchiteture.Application.ShoppingLists.Queries
{
    public class GetAllShoppingListsQuery : IRequest<ShoppingListVm>
    {
    }
}
