using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.UserStory
{
    public class AddUserStoryHandler : IRequestHandler<AddUserStoryContext, int>
    {
        private readonly IRepository<DbUserContext> _repository;
        private readonly IMapper _mapper;

        public AddUserStoryHandler(IRepository<DbUserContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddUserStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new User());

            return await _repository.InsertAsync(asteroid);
        }
    }
}
