using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.BooksContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.BookStory
{
    public class ShowAllBooksStoryHandler : IRequestHandler<ShowAllBooksStoryContext, List<Book>>
    {
        private readonly IRepository<DbLibraryContext> _repository;

        public ShowAllBooksStoryHandler(IRepository<DbLibraryContext> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<Book>> Handle(ShowAllBooksStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<Book>();

            return item.ToList();
        }
    }
}
