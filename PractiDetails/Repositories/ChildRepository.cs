
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
    public class ChildRepository : IRepository<Child>
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async  Task<Child> AddAsync(Child entity)
        {
            EntityEntry<Child> c = await _context.children.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
                
        }

        public async Task DeleteAsync(int id)
        {
            _context.children.Remove(_context.children.FirstOrDefault(c => c.Id == id));
             _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.children.FindAsync( id);
        }

        public async Task<Child> UpdateAsync(Child entity)
        {
            var newOne = _context.children.Update(entity);
            await _context.SaveChangesAsync();
            return newOne.Entity;
        }
    }
}
