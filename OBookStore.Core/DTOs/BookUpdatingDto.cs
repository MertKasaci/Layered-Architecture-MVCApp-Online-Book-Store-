using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DTOs
{
    public class BookUpdatingDto
    {
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfEdition { get; set; }
        public int NumberOfStocks { get; set; }
        public decimal Price { get; set; }

    }
}
