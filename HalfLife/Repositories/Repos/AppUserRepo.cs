using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HalfLife.Models.DbModels;
using HalfLife.Repositories.IRepos;

namespace HalfLife.Repositories.Repos
{
    public class AppUserRepo : IAppUserRepo
    {
        public Task<bool> Create(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
