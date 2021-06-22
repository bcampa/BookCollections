using System;
using System.Collections.Generic;

namespace BookCollections.Entities.Models
{
    public class User
    {
        public User()
        {
            BookCollections = new HashSet<BookCollection>();
        }

        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookCollection> BookCollections { get; set; }
    }
}
