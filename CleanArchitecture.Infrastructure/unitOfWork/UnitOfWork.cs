using CleanArchitecture.Domain.IRepositories;
using CostItArchitecture.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostItArchitecture.Infrastructure.unitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CostItDbcontext _context;

        public UnitOfWork(CostItDbcontext context)
        {
            _context = context;
            //add your implementation object here
            // e.g Something = new ISomething(_context)
        }

        //Add Your Interfaces here
        //e.g public ISomething Something {get; set;}
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
