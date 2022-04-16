using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.Repositories;
using library.Entities;


namespace library
{
    class Program
    {
        static async Task Main()
        {
            db_libraryContext libraryContext = new db_libraryContext();
            IRepository repository = new Repository(libraryContext);

            Book book = await repository.Get<Book>(2);

            Console.WriteLine(book.BookName);
        }
    }
}
