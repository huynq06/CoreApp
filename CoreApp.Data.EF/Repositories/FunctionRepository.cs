using CoreApp.Data.Entities;
using CoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
