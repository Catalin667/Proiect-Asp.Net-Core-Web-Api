using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.DisciplineRepository
{
    public interface IDisciplineRepository : IGenericRepository<Disciplina>
    {
        Task<Disciplina> GetDisciplinaById (int id);
        Task<List<Disciplina>> GetAllDiscipline();
    }
}
