using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IUnitOfWork:IDisposable
    {
        void Commit();
        DbSet<T> GetDbSet<T>() where T : class;
    }
    class UnitOfWork : IUnitOfWork,IDisposable
    {
        public readonly DbContext context;
        public UnitOfWork(DbContext _context)
        {
            this.context = _context;
        }
        
        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return context.Set<T>();
        }
    }
}
