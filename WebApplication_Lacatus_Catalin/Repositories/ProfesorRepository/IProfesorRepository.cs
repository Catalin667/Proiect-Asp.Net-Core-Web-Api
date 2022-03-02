using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.ProfesorRepository
{
    public interface IProfesorRepository : IGenericRepository<Profesor>
    {
 
        Task<Sala> GetByIdwithSala(int id);
        Task<List<Profesor>> GetAllProfesoriWithSali();
         
        Task<Profesor> GetByIdProfesor(int id);
      
    }
}
