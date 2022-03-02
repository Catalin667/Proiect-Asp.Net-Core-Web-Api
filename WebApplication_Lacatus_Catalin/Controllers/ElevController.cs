using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Entitati.DTOs;
using WebApplication_Lacatus_Catalin.Repositories.ElevRepository;

namespace WebApplication_Lacatus_Catalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevController : ControllerBase
    {
        private readonly IElevRepository _repository;

        public ElevController(IElevRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllElevi()
        {
            var elev = await _repository.GetAllElevi();

            var ElevToReturn = new List<ElevDTO>();

            foreach (var Elev in elev)
            {
                ElevToReturn.Add(new ElevDTO(Elev));
            }

            return Ok(ElevToReturn);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetByIdElev(int id)
        {
            var elev = await _repository.GetByIdElev(id);
            if (elev == null)
            {
                return NotFound("Elevul does not exist!");
            }
            return Ok(new ElevDTO(elev));
        }

        [HttpPut("{id}/{varsta}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update_varsta_elev(int id, int varsta)
        {
            var elev = await _repository.GetByIdElev(id);

            if (elev == null)
            {
                return NotFound("Elevul nu exista!");
            }

            elev.Varsta = varsta;

            await _repository.SaveAsync();

            return Ok(new ElevDTO(elev));
        }


        [HttpPost]
       /// [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateElev(CreateElevDTO dto)
        {
            Elev newelev = new Elev();

            newelev.Nume = dto.Nume;
            newelev.Prenume = dto.Prenume;
            newelev.Varsta = dto.Varsta;
            newelev.Telefon = dto.Telefon;
            newelev.Email = dto.Email;
            newelev.Ocupatia = dto.Ocupatia;

            _repository.Create(newelev);

            await _repository.SaveAsync();

            return Ok(new ElevDTO(newelev));
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            var elev = await _repository.GetByIdElev(id);

            if (elev == null)
            {
                return NotFound("Elevul nu exista!");
            }

            _repository.Delete(elev);

            await _repository.SaveAsync();

            return NoContent();
        }


    }
}
