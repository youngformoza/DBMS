using LibraryAPI.Models.AnalyticsModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts;
using MediatR;
using MongoDB.Bson;

namespace LibraryAPI.Stories.AnalyticsStories.BookAnalyticsStories
{
    public class DeleteBookAnalyticsStoryHandler : IRequestHandler<DeleteBookAnalyticsStoryContext, bool>
    {
        private readonly IMongoRepository _repository;

        public DeleteBookAnalyticsStoryHandler(IMongoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteBookAnalyticsStoryContext request,
            CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(new ObjectId(request.Id));
            return true;
        }
    }
}
