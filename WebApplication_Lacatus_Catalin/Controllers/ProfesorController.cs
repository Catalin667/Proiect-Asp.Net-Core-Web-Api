using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Entitati.DTOs;
using WebApplication_Lacatus_Catalin.Repositories.ProfesorRepository;

namespace WebApplication_Lacatus_Catalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorRepository _repository;
        public ProfesorController(IProfesorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllProfesorWithSala()
        {
            var profesor = await _repository.GetAllProfesoriWithSali();

            var ProfesoriToReturn = new List<ProfesorDTO>();

            foreach (var Profesor in profesor)
            {
                ProfesoriToReturn.Add(new ProfesorDTO(Profesor));
            }

            return Ok(ProfesoriToReturn);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProfesor(CreateProfesorDTO dto)
        {
            Profesor newprofesor = new Profesor();
            
            newprofesor.Nume = dto.Nume;
            newprofesor.Prenume = dto.Prenume;
            newprofesor.Telefon = dto.Telefon;
            newprofesor.Email = dto.Email;
            newprofesor.Data_angajarii = dto.Data_angajarii;
            newprofesor.Salariu = dto.Salariu;
            newprofesor.Specializari = dto.Specializari;
            newprofesor.Sala = dto.Sala;
             
           

            _repository.Create(newprofesor);

            await _repository.SaveAsync();

            return Ok(new ProfesorDTO(newprofesor));
        }

        [HttpPut("{id}/{telefon}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update_varsta_elev(int id, string telefon)
        {
            var profesor = await _repository.GetByIdProfesor(id);

            if (profesor == null)
            {
                return NotFound("Profesorul nu exista!");
            }

            profesor.Telefon = telefon;

            await _repository.SaveAsync();

            return Ok(new ProfesorDTO(profesor));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetSalaByProfesorId(int id)
        {
            var sala = await _repository.GetByIdwithSala(id);
            if(sala ==null)
            {
                return NotFound("Profesor does not exist!");
            }
            return Ok(new  GetSalaProfesorDTO(sala));
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            var profesor = await _repository.GetByIdProfesor(id);

            if (profesor == null)
            {
                return NotFound("Profesor does not exist!");
            }

            _repository.Delete(profesor);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}