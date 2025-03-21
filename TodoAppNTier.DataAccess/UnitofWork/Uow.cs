using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppNTier.DataAccess.Contexts;
using TodoAppNTier.DataAccess.Interfaces;
using TodoAppNTier.DataAccess.Repositories;

namespace TodoAppNTier.DataAccess.UnitofWork
{
    public class Uow : IUow
    {

        private readonly TodoContext _context;

        public Uow(TodoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
             await _context.SaveChangesAsync();
        }
    }
}
