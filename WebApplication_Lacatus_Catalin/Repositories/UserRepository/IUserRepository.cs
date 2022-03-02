using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Modules.Entity_Modules;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;
//using WebApplication_Lacatus_Catalin.Repositories.SessionTokenRepository;

namespace WebApplication_Lacatus_Catalin.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
   
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByEmail(string email);
        Task<User> GetByIdWithRoles(int id);
         
    }
}
