using BookCollections.Entities.Models;
using BookCollections.Entities.Repositories.Contracts;

namespace BookCollections.Entities.Repositories.Concretes
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository() : base() { }
    }
}
