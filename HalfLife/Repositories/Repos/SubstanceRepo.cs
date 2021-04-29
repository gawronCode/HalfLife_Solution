using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HalfLife.Models.DbModels;
using HalfLife.Repositories.IRepos;

namespace HalfLife.Repositories.Repos
{
    public class SubstanceRepo : ISubstanceRepo
    {
        public Task<bool> Create(Substance entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Substance entity)
        {
            throw new NotImplementedException();
        }

        public Task<Substance> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
