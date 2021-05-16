using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus.Domain.Common
{
    public interface IRepository<TEntity> where TEntity : DomainEntity
    {
        ///// <summary>
        ///// Gets the <see cref="IUnitOfWork"/> associated with this repository.
        ///// </summary>
        //IUnitOfWork UnitOfWork
        //{
        //    get;
        //}

        /// <summary>
        /// Retrieves the total number of entities in the data store.
        /// </summary>
        /// <returns>The number of entities.</returns>
        int Count();
    }
}
