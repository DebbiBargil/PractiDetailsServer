
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PractiDetails.Models;
using PractiDetails.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiDetails.Repositories.Repositories
{
    public class ParentRepository : IRepository<Parent>
    {
        private readonly IContext _context;

        public ParentRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Parent> AddAsync(Parent entity)
        {
            EntityEntry<Parent> c = await _context.parents.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.parents.Remove(_context.parents.FirstOrDefault(c => c.Id == id));
            _context.SaveChangesAsync();
        }

        public async Task<List<Parent>> GetAllAsync()
        {
            return await _context.parents.ToListAsync();
        }

        public async Task<Parent> GetByIdAsync(int id)
        {
            return await _context.parents.FindAsync(id);

        }

        public async Task<Parent> UpdateAsync(Parent entity)
        {
            var newOne = _context.parents.Update(entity);
            await _context.SaveChangesAsync();
            return newOne.Entity;
        }
    }
}
