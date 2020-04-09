using CoreAppArchiteture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppArchiteture.Core.Interfaces
{
    public interface IRepositoryAsync : IAsyncRepository<ShoppingList>
    {
        Task<ShoppingList> GetByIdWithItemsAsync(int id);
    }
}
