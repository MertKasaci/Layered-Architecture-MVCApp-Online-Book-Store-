using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DTOs
{
    public  class OrderDto
    {
        public Guid UserId { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
