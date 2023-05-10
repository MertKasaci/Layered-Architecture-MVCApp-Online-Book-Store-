using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DataGenerator
{
    public interface IDataGenerator
    {

        List<Book> bookDataGenerator();
        List<Publisher> publisherDataGenerator();
    }
}
