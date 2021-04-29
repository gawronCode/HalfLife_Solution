using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HalfLife.Models.DbModels;
using HalfLife.Repositories.IRepos;

namespace HalfLife.Repositories.Repos
{
    public class AppUserSubstanceRepo : IAppUserSubstanceRepo
    {
        public Task<bool> Create(AppUserSubstance entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(AppUserSubstance entity)
        {
            throw new NotImplementedException();
        }

        public Task<AppUserSubstance> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
