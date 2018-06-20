
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IUnitOfWork uoc = new UnitOfWork(new DbContext("")))
            {
                uoc.GetDbSet<Employee>();
                uoc.Commit();
            }
            dynamic d = new byte[100];
                
        }
    }
}
