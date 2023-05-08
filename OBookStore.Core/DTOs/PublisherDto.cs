using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DTOs
{
    public class PublisherDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AddressDescription { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
