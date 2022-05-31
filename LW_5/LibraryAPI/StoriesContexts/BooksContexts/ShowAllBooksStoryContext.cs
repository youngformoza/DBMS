using LibraryAPI.Models.BookModels;
using MediatR;

namespace LibraryAPI.StoriesContexts.BooksContexts
{
    public class ShowAllBooksStoryContext : IRequest<List<Book>>
    {
    }
}
