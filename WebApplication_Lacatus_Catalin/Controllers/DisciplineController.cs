using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Entitati.DTOs;
using WebApplication_Lacatus_Catalin.Repositories.DisciplineRepository;

namespace WebApplication_Lacatus_Catalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineRepository _repository;
        public DisciplineController(IDisciplineRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        
        public async Task<IActionResult> GetAllDiscipline()
        {
            var disciplina = await _repository.GetAllDiscipline();

            var DisciplinaToReturn = new List<DisciplinaDTO>();

            foreach (var Disciplina in disciplina)
            {
                DisciplinaToReturn.Add(new DisciplinaDTO(Disciplina));
            }

            return Ok(DisciplinaToReturn);
        }

        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateDisciplina(CreateDisciplineDTO dto)
        {
            Disciplina newdisciplina = new Disciplina();

            newdisciplina.Denumire_disciplina = dto.Denumire_disciplina;
            newdisciplina.Nr_ore_sapt = dto.Nr_ore_sapt;
            newdisciplina.Nr_examene = dto.Nr_examene;
          
            _repository.Create(newdisciplina);

            await _repository.SaveAsync();

            return Ok(new DisciplinaDTO(newdisciplina));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDisciplinaById(int id)
        {
            var disciplina = await _repository.GetDisciplinaById(id);
            if (disciplina == null)
            {
                return NotFound("Disciplina does not exist!");
            }
            return Ok(new DisciplinaDTO(disciplina));
        }
        [HttpPut("{id}/{nr_ore_sapt}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update_nr_ore_sapt(int id,int nr_ore_sapt)
        {
            var disciplina = await _repository.GetDisciplinaById(id);

            if (disciplina == null)
            {
                return NotFound("Disciplina nu exista!");
            }

            disciplina.Nr_ore_sapt = nr_ore_sapt;

            await _repository.SaveAsync();

            return Ok(new DisciplinaDTO(disciplina));
        }

        [HttpPut("Update_nr_examene/{id}/{nr_examene}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update_nr_examene(int id, int nr_examene)
        {
            var disciplina = await _repository.GetDisciplinaById(id);

            if (disciplina == null)
            {
                return NotFound("Disciplina nu exista!");
            }

            disciplina.Nr_examene = nr_examene;

            await _repository.SaveAsync();

            return Ok(new DisciplinaDTO(disciplina));
        }

        [HttpPut("Update_denumire_disciplina/{id}/{denumire_disciplina}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update_denumire_disciplina(int id, string denumire_disciplina)
        {
            var disciplina = await _repository.GetDisciplinaById(id);

            if (disciplina == null)
            {
                return NotFound("Disciplina nu exista!");
            }

            disciplina.Denumire_disciplina = denumire_disciplina;

            await _repository.SaveAsync();

            return Ok(new DisciplinaDTO(disciplina));
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            var disciplina = await _repository.GetDisciplinaById(id);

            if (disciplina == null)
            {
                return NotFound("Disciplina nu exista!");
            }

            _repository.Delete(disciplina);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
