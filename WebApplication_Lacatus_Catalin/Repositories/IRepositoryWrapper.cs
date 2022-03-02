using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Repositories;

namespace WebApplication_Lacatus_Catalin.Repositories
{
    public interface IRepositoryWrapper
    {

        IUserRepository User { get; }
        ISessionTokenRepository SessionToken { get; }

        Task SaveAsync();
    }
}
