using BookCollections.Entities.Models;
using BookCollections.Entities.Repositories.Contracts;
using System;
using System.Linq;

namespace BookCollections.Entities.Repositories.Concretes
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base() { }

        public User GetByGuid(Guid guid)
        {
            return _context.Users
                .Where(x => x.Guid == guid)
                .SingleOrDefault();
        }
    }
}
