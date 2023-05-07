using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.Entities
{
    public class Publisher : BaseEntity
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AddressDescription { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
