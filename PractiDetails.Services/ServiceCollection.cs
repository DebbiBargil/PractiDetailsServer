using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PractiDetails.Common.DTOs;
using PractiDetails.Repositories;
using PractiDetails.Services.Interfaces;
using PractiDetails.Services.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiDetails.Services
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddServices(this IServiceCollection s)
        {
            s.AddRepositories();
            s.AddScoped<IService<ChildDto>, CildServices>();
            s.AddScoped<IService<ParentDto>,ParentServices>();
            s.AddSingleton<IContext, DetailsContext>();
            s.AddAutoMapper(typeof(MappingProfile));
            return s;
        }
    }
}
