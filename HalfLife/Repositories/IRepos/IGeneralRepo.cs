using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalfLife.Repositories.IRepos
{
    public interface IGeneralRepo<T> where T : class
    {
        Task<T> GetById(int id);
        Task<bool> Create(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Save();
    }
}
