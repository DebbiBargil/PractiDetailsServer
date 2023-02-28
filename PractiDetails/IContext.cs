using Microsoft.EntityFrameworkCore;
using PractiDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiDetails.Repositories
{
    public interface IContext
    {
        DbSet<Child> children { get; set; }
        DbSet<Parent> parents { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
