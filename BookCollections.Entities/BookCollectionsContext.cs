using BookCollections.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCollections.Entities
{
    public class BookCollectionsContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CollectionItem> CollectionItems { get; set; }
        public virtual DbSet<BookCollection> BookCollections { get; set; }
        private static bool _created = false;

        public BookCollectionsContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=book_collections.db");
    }
}
