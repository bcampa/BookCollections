using System.Collections.Generic;

namespace BookCollections.Entities.Models
{
    public class BookCollection
    {
        public BookCollection()
        {
            CollectionItems = new HashSet<CollectionItem>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<CollectionItem> CollectionItems { get; set; }
    }
}
