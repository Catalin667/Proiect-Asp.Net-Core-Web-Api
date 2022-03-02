using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.ElevRepository
{
    public interface IElevRepository: IGenericRepository<Elev>
    {
        Task<Elev> GetByIdElev(int id);
        Task<List<Elev>> GetAllElevi();
    }
}
