using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DmiConsulting.Eshop.Core.Entities;

namespace DmiConsulting.Eshop.Core.Interfaces
{
    public interface IAsyncRepository<T> where T: BaseEntity
    {

        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
