using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deus.Domain.Common;

namespace Deus.Persistence.Common
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : DomainEntity
    {
        private readonly DeusContext _context;
        //private IDbSet<T> entities;
        //string errorMessage = string.Empty;

        public Repository(DeusContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this._context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        public DeusContext Context
        {
            get
            {
                return _context;
            }
        }
        //public virtual IQueryable<T> Table
        //{
        //    get
        //    {
        //        return this.Entities;
        //    }
        //}
        //private IDbSet<T> Entities
        //{
        //    get
        //    {
        //        if (entities == null)
        //        {
        //            entities = context.Set<T>();
        //        }
        //        return entities;
        //    }
        //}

        public int Count()
        {
            return _context.Set<TEntity>().Count();
        }
    }
}
