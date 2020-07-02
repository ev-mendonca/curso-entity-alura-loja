
using Data.Entities;
using Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity 
    {
        protected readonly Context Context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(Context context)
        {
            Context = context;
            dbSet = context.Set<T>();
        }

        public IList<T> Listar()
        {
            return dbSet.ToList();
        }
    }
}
