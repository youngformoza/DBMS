using AutoMapper;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.BooksContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.BookStory
{
    public class UpdateBookStoryHandler : IRequestHandler<UpdateBookStoryContext, bool>
    {
        private readonly ILibraryRepository _repository;
        private readonly IMapper _mapper;

        public UpdateBookStoryHandler(ILibraryRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateBookStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Book());
            var response = await _repository.UpdateAsync(asteroid);

            return response;
        }
    }
}
