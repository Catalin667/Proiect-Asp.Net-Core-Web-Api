using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.ElevRepository
{
    public class ElevRepository : GenericRepository<Elev>, IElevRepository
    {
        public ElevRepository(Context context) : base(context) { }

        public async Task<List<Elev>> GetAllElevi()
        {
            return await _context.Elev.ToListAsync();
        }

        public async Task<Elev> GetByIdElev(int id)
        {
            return await _context.Elev.Where(e => e.Id == id).FirstOrDefaultAsync();
        }
    }
}
