using LibraryAPI.Models.BookModels;
using MediatR;

namespace LibraryAPI.StoriesContexts.LibraryStoriesContexts.BooksContexts
{
    public class ShowAllBooksStoryContext : IRequest<List<Book>>
    {
    }
}
