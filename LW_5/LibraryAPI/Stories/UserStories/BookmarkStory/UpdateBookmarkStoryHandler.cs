using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.BookmarkStory
{
    public class UpdateUserStoryHandler : IRequestHandler<UpdateBookmarkStoryContext, bool>
    {
        private readonly IRepository<DbUserContext> _repository;
        private readonly IMapper _mapper;

        public UpdateUserStoryHandler(IRepository<DbUserContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateBookmarkStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Bookmark());
            var response = await _repository.UpdateAsync(asteroid);

            return response;
        }
    }
}
