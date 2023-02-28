using Microsoft.Extensions.DependencyInjection;
using PractiDetails.Models;
using PractiDetails.Repositories.Interfaces;
using PractiDetails.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiDetails.Repositories
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection s)
        {
            s.AddScoped<IRepository<Child>, ChildRepository>();
            s.AddScoped<IRepository<Parent>, ParentRepository>();
            return s;   
        }
        
    }
}
