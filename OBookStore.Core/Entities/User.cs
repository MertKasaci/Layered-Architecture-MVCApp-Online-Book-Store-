using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Comments = new HashSet<Comment>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressDescription { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Cart Cart { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }
}
