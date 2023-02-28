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
    public class ParentServices : IService<ParentDto>
    {
        private readonly IRepository<Parent> _parentRepository;
        private readonly IMapper _mapper;
        public ParentServices(IRepository<Parent> parentRepository, IMapper mapper)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
        }

        public async Task<ParentDto> AddAsync(ParentDto entity)
        {
            return _mapper.Map<ParentDto>(await _parentRepository.AddAsync (_mapper.Map<Parent>(entity)));
        }

        public async Task DeleteAsync(int id)
        {
            await _parentRepository.DeleteAsync(id);

        }

        public async Task<List<ParentDto>> GetAllAsync()
        {
            return  _mapper.Map<List<ParentDto>>(await _parentRepository.GetAllAsync());

        }

        public async Task<ParentDto> GetByIdAsync(int id)
        {
            return  _mapper.Map<ParentDto>(_parentRepository.GetByIdAsync(id));

        }

        public async Task<ParentDto> UpdateAsync(int id,ParentDto entity)
        {
            Parent parent=_mapper.Map<Parent>(entity);
            parent=await _parentRepository.UpdateAsync(parent);
            return _mapper.Map<ParentDto>(parent);
        }
    }
}
