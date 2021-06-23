using System.Collections.Generic;

namespace BookCollections.Entities.Models
{
    public class Book
    {
        public Book()
        {
            CollectionItems = new HashSet<CollectionItem>();
        }

        public int Id { get; set; }

        public virtual ICollection<CollectionItem> CollectionItems { get; set; }
    }
}
