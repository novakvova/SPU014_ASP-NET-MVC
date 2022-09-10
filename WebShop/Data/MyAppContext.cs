using Microsoft.EntityFrameworkCore;
using WebShop.Data.Entities;

namespace WebShop.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options) { }

        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
