using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.Entities
{
    public class Comment : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfDislikes { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }


    }
}
