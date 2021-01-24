using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Core.AppCommon
{
    public interface IEntityManager<TEntity, TPrimaryKey> : IDomainService
    {
        Task<TEntity> GetAsync(TPrimaryKey id);

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }

}
