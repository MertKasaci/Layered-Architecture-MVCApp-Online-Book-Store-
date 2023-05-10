using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.Entities
{
    public class Book : BaseEntity // maybe later can implement book class partially.
    {
        public Book()
        {
            Comments = new HashSet<Comment>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfEdition { get; set; }
        public int NumberOfStocks { get; set; }
        public int NumberOfSolds { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfDislikes { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
            
        public Category Category { get; set; } // Book is dependent to the category so should have foreign key for category.
        public Publisher Publisher { get; set; } // Book is dependent to the publisher so should have foreign key for publisher.
        public ICollection<Author> Authors { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Order> Orders { get; set; }

     }
    

    
}
