using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.BooksContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.BookStory
{
    public class ShowBookStoryHandler : IRequestHandler<ShowBookStoryContext, Book>
    {
        private readonly ILibraryRepository _repository;

        public ShowBookStoryHandler(ILibraryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Book> Handle(ShowBookStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync<Book>(request.Id);
            return item;
        }
    }
}
