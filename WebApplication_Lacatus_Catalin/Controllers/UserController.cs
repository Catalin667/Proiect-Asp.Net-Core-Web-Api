using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Repositories;
using WebApplication_Lacatus_Catalin.Entitati;

namespace WebApplication_Lacatus_Catalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public UserController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _repository.User.GetAllUsers();

            return Ok(new { users });
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetByIdWithRoles(int id)
        {
            var users = await _repository.User.GetByIdWithRoles(id);
            if(users == null)
                return NotFound("Userul does not exist!");

            return Ok(new { users });
        }

        [HttpGet("GetUserByEmail/{email}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var users = await _repository.User.GetUserByEmail(email);
            
            if (users == null)
                return NotFound("Userul does not exist or is not registered with this email!");

            return Ok(new { users });
        }
        
    }
}
