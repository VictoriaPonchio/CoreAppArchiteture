using CoreAppArchiteture.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;  


namespace CoreAppArchiteture.Infrastructure
{
    public class CoreAppContext : DbContext
    {
        public CoreAppContext(DbContextOptions<CoreAppContext> options) : base(options) { }

        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
