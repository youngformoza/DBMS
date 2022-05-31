using AutoMapper;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.BooksContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.BookStory
{
    public class AddBookStoryHandler : IRequestHandler<AddBookStoryContext, int>
    {
        private readonly ILibraryRepository _repository;
        private readonly IMapper _mapper;

        public AddBookStoryHandler(ILibraryRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddBookStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Book());

            return await _repository.InsertAsync(asteroid);
        }
    }
}
