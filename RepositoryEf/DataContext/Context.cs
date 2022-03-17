using Entities.Pocos;
using Microsoft.EntityFrameworkCore;

namespace RepositoryEf.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
