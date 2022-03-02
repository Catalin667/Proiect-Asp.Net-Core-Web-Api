using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.DisciplineRepository
{
    public class DisciplineRepository : GenericRepository<Disciplina>, IDisciplineRepository
    {
        public DisciplineRepository(Context context) : base(context) { }
        
        public async Task<List<Disciplina>> GetAllDiscipline() ///obtine toate disciplinele
        {
            return await _context.Disciplina.ToListAsync();
        }

        public async Task<Disciplina> GetDisciplinaById(int id) /// obtine disciplina cu un id specificat 
        {
            return await _context.Disciplina.Where(d => d.DisciplinaId == id).FirstOrDefaultAsync();
        }
    }
}
