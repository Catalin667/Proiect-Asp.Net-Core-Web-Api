using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Modules.Entity_Modules;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;
using WebApplication_Lacatus_Catalin.Repositories;

namespace WebApplication_Lacatus_Catalin.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdWithRoles(int id)
        {
            return await _context.Users
                .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public async Task<User> GetUserByEmail(string email)
        {
            /// return await _context.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
            ///return await _context.Users.Where(u => u.Email.Equals(email)).FirstOrDefaultAsync();
            return await _context.Users
                .Include(u => u.UserRoles).ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
