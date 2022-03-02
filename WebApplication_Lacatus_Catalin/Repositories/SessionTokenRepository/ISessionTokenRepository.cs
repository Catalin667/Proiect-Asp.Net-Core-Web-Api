using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Modules.Entity_Modules;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;

namespace WebApplication_Lacatus_Catalin.Repositories//.SessionTokenRepository
{
        public interface ISessionTokenRepository : IGenericRepository<SessionToken>
        {
        object SessionToken { get; }

        Task<SessionToken> GetByJTI(string jti);
        }

    
}
