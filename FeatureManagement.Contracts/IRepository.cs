using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManagement.Contracts
{
    public interface IRepository<T> where T: IAggregateRoot
    {
        Task AddAsync(T item);

        Task UpdateAsync(T item);

        Task DeleteAsync(T item);

        Task GetAsync(int id);
    }
}
