using AutoMapper;
using PractiDetails.Common.DTOs;
using PractiDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiDetails.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Child, ChildDto>().ReverseMap();
            CreateMap<Parent, ParentDto>().ReverseMap();

        }
    }
}
