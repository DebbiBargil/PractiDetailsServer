using AutoMapper;
using PractiDetails.Common.DTOs;
using PractiDetails.Models;
using PractiDetails.Repositories.Interfaces;
using PractiDetails.Repositories.Repositories;
using PractiDetails.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiDetails.Services.Services
{
    public class CildServices : IService<ChildDto>
    {
        private readonly IRepository<Child> _childRepository;
        private readonly IMapper _mapper;
        public CildServices(IRepository<Child> childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }
        public async Task<ChildDto> AddAsync(ChildDto entity)
        {

            return _mapper.Map<ChildDto>(await _childRepository.AddAsync(_mapper.Map<Child>(entity)));
        }

    

        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeleteAsync(id);
          

        }

        public async Task<List<ChildDto>> GetAllAsync()
        {
         

            return _mapper.Map<List<ChildDto>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDto> GetByIdAsync(int id)
        {
           
            return _mapper.Map<ChildDto>(_childRepository.GetByIdAsync(id));

        }

        public async Task<ChildDto> UpdateAsync(int id,ChildDto entity)
        {

            ;
            Child child = _mapper.Map<Child>(entity);
            child = await _childRepository.UpdateAsync(child);
            return _mapper.Map<ChildDto>(child);
        }
    }
}
