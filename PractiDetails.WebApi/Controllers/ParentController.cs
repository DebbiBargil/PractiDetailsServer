using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PractiDetails.Common.DTOs;
using PractiDetails.Models;
using PractiDetails.Services.Interfaces;
using PractiDetails.WebApi.Models;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PractiDetails.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IService<ParentDto> _parent;

        public ParentController(IService<ParentDto> parent)
        {
            _parent = parent;
        }
    

        // GET: api/<ParentController>
        [HttpGet]

        public async Task<List<ParentDto>> Get()
        {
            return await _parent.GetAllAsync();
        }

        // GET api/<ParentController>/5
        [HttpGet("{id}")]
        public async Task<ParentDto> Get(int id)
        {
            return await _parent.GetByIdAsync(id);
        }

        // POST api/<ParentController>
        [HttpPost]
        public async Task<ParentDto> Post([FromBody] ParentDto postModel)
        {
            ParentDto newOne = new ParentDto();
         
            return await _parent.AddAsync(postModel);
        }

        // PUT api/<ParentController>/5
        [HttpPut("{id}")]
        public async Task<ParentDto> Put(int id, [FromBody] ParentDto value)
        {
            return await _parent.UpdateAsync(id, value);
        }

        // DELETE api/<ParentController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _parent.DeleteAsync(id);  
        }
    }
}
