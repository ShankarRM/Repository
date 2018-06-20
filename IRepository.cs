using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IRepository<T> where T :class
    {
        IQueryable<T> Fetch();
    }
    class Repository<T> : IRepository<T> where T:class
    {
        public readonly IUnitOfWork uoc;
        public Repository(IUnitOfWork _uoc)
        {
            _uoc = uoc;
        }
        public IQueryable<T> Fetch()
        {
            return uoc.GetDbSet<T>();
        }
    }
}
