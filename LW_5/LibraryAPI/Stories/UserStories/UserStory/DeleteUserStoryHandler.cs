using AutoMapper;
using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts;
using MediatR;

namespace LibraryAPI.Stories.UserStories.UserStory
{
    public class DeleteUserStoryHandler : IRequestHandler<DeleteUserStoryContext, bool>
    {
        private readonly IUserRepository _repository;

        public DeleteUserStoryHandler(IUserRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteUserStoryContext request,
            CancellationToken cancellationToken)
        {
            var deleted = await _repository.DeleteAsync<User>(request.Id);
            return deleted;
        }
    }
}
