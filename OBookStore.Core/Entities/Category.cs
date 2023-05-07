using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.Entities
{
    
    public class Category : BaseEntity
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }
        public string Title { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
