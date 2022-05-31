using AutoMapper;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.BooksContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.BookStory
{
    public class DeleteBookStoryHandler : IRequestHandler<DeleteBookStoryContext, bool>
    {
        private readonly ILibraryRepository _repository;

        public DeleteBookStoryHandler(ILibraryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteBookStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<Book>(request.Id);
            return deleted;
        }
    }
}
