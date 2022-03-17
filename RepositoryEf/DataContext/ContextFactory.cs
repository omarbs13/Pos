using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RepositoryEf.DataContext
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<Context>();
            // OptionsBuilder.UseSqlServer("Data Source=OMAR;Initial Catalog=LatinoNet;Trusted_Connection=true");

            return new Context(OptionsBuilder.Options);
        }
    }
}
