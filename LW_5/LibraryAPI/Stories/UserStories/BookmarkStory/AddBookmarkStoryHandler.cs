using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.UserStory
{
    public class AddBookmarkStoryHandler : IRequestHandler<AddBookmarkStoryContext, int>
    {
        private readonly IRepository<DbUserContext> _repository;
        private readonly IMapper _mapper;

        public AddBookmarkStoryHandler(IRepository<DbUserContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddBookmarkStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Bookmark());

            return await _repository.InsertAsync(asteroid);
        }
    }
}
