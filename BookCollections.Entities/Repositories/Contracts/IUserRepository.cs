using BookCollections.Entities.Models;
using System;

namespace BookCollections.Entities.Repositories.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByGuid(Guid guid);
    }
}
