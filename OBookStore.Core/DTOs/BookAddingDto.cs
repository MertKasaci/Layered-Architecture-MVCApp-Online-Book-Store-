using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DTOs
{
    public class BookAddingDto 
    {
       public string Title { get; set; }
       public string Description { get; set; }
       public int NumberOfPages { get; set; }
       public int NumberOfEdition { get; set; }
       public int NumberOfStocks { get; set; }
       public decimal Price { get; set; }
       public int CategoryId { get; set; }
       public int PublisherId { get; set; }
       public ICollection<Author> Authors { get; set; }



    }
}
