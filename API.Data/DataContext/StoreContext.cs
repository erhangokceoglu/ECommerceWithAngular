using API.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.Data.DataContext
{
    public class StoreContext :DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}
