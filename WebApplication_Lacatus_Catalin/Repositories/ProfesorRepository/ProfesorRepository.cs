using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.ProfesorRepository
{
    public class ProfesorRepository : GenericRepository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(Context context) : base(context) { }

        public async Task<Sala> GetByIdwithSala(int id)
        {
           
            return await _context.Sala.Where(s => s.ProfesorId == id).FirstOrDefaultAsync();
        }

        public async Task<List<Profesor>> GetAllProfesoriWithSali()
        {
            return await _context.Profesor.Include(a => a.Sala).ToListAsync();
        }

        public async Task<Profesor> GetByIdProfesor(int id)
        {
            return await _context.Profesor.Where(a => a.ProfesorId == id).FirstOrDefaultAsync();
        }

         
    }
}
