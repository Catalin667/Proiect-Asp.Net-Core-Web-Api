using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Entitati.DTOs;
using WebApplication_Lacatus_Catalin.Repositories.ProfDisElevRepository;
using WebApplication_Lacatus_Catalin.Repositories.ProfesorDisciplinaElevRepository;

namespace WebApplication_Lacatus_Catalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfDisElevController : ControllerBase
    {
        private readonly IProfDisElevRepository _repository;
        public ProfDisElevController(IProfDisElevRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetProfesorWithDisciplineAndElevi()
        {
            var ProfesoriCuInformatii = await _repository.GetProfesorWithDisciplineAndElevi();

            var ProfesoriToReturn = new List<ProfDisciplinaElevDTO>();

            foreach (var ProfesorDisciplinaElev in ProfesoriCuInformatii)
            {
                ProfesoriToReturn.Add(new ProfDisciplinaElevDTO(ProfesorDisciplinaElev));
            }

            return Ok(ProfesoriToReturn);
        }
        
        [HttpGet("GetDiscipline")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetDisciplineWithProfesori()
        {
            List<objectProfesorDisciplinaElev> DisciplineCuInformatii = await _repository.GetDisciplineWithProfesori(); 
            return  Ok(DisciplineCuInformatii);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProfesorElevDisciplina(ProfesorElevDisciplinaCreateDTO dto)
        {
            ProfesorDisciplinaElev newProfesorDisciplinaElev= new ProfesorDisciplinaElev();

            newProfesorDisciplinaElev.ProfesorId = dto.ProfesorId;
            newProfesorDisciplinaElev.DisciplinaId = dto.DisciplinaId;
            newProfesorDisciplinaElev.ElevId = dto.ElevId;
            newProfesorDisciplinaElev.an_studiu = dto.an_studiu;
            
            _repository.Create(newProfesorDisciplinaElev);

            await _repository.SaveAsync();

            return Ok(new ProfesorDisciplinaElevDTO(newProfesorDisciplinaElev));
        }
        /*
        [HttpGet("GroupBy")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> SalariiMediiPeDiscipline()
        {

            var result = await _repository.GetAllInformations();
            var query = result.GroupBy(
                pr => pr.DisciplinaId,
                pr => pr.Profesor.Salariu,
                (disciplina, salariu) => new { Key = disciplina, sal_mediu = salariu.Average() }
                );
            return Ok(query);
        }
        */
    }
}
