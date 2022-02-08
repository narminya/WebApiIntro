using AutoMapper;
using Domain.DTO;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        private readonly IRepository<Student> _repository;
        private readonly IMapper _mapper;
        public StudentsController(IRepository<Student> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _repository.GetAllAsync();
            return Ok(_mapper.Map<List<StudentDto>>(students));
        }

        [HttpGet("id")]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var student = await _repository.GetAsync(id);
            return Ok(student);
        }
    }
}
