using Microsoft.AspNetCore.Mvc;
using PractiDetails.Common.DTOs;
using PractiDetails.Services.Interfaces;
using PractiDetails.WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PractiDetails.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IService<ChildDto> _child;

        public ChildController(IService<ChildDto> child)
        {
            _child = child;
        }

        // GET: api/<ChildController>
        [HttpGet]
        public async Task<List<ChildDto>> Get()
        {
            return await _child.GetAllAsync();
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public async Task<ChildDto> Get(int id)
        {
            return await _child.GetByIdAsync(id);
        }

        // POST api/<ChildController>
        [HttpPost]
        public async Task<ChildDto> Post ([FromBody] ChildModel postModel)
        {
            ChildDto newOne = new ChildDto();
            newOne.Id = postModel.Id;   

            newOne.BirthDate = DateTime.Now;

            newOne.ParentIdNumber=postModel.ParentIdNumber; 

            newOne.IdNumber=postModel.IdNumber;

            newOne.FirstName = postModel.FirstName;

            return await _child.AddAsync(newOne);
        }
 

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public async Task<ChildDto> Put(int id, [FromBody] ChildDto value)
        {
            return await _child.UpdateAsync(id, value);
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _child.DeleteAsync(id);
        }
    }
}
