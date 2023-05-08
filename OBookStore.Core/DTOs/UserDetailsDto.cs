using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DTOs
{
    public class UserDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressDescriptipon { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public ICollection<Order>Orders { get; set; }
        public ICollection<Comment>Comments { get; set; }
    }
}
