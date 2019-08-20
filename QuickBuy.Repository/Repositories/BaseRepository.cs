using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> : where TEntity : class
    {
    }
}
