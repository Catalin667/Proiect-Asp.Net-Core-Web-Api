using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Entitati.DTOs;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;
using WebApplication_Lacatus_Catalin.Repositories.ProfDisElevRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.ProfesorDisciplinaElevRepository
{
    public interface IProfDisElevRepository : IGenericRepository<ProfesorDisciplinaElev>
    {
        Task<List<ProfesorDisciplinaElev>> GetAllInformations();
        Task<List<ProfesorDisciplinaElev>> GetProfesorWithDisciplineAndElevi();
        Task<List<objectProfesorDisciplinaElev>> GetDisciplineWithProfesori();
    
    }
}
