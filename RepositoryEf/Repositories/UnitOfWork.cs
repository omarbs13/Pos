using Entities.Interfaces;
using RepositoryEf.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEf.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly Context Context;
        public UnitOfWork(Context context) => Context = context;

        public Task<int> SaveChanges()
        {
            return Context.SaveChangesAsync();
        }
    }
}
