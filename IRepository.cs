﻿using System;
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
    
}
