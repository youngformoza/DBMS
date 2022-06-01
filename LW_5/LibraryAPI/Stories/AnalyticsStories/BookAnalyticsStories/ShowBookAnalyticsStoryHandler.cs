using LibraryAPI.Models.AnalyticsModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts;
using MediatR;
using MongoDB.Bson;

namespace LibraryAPI.Stories.AnalyticsStories.BookAnalyticsStories
{
    public class ShowBookAnalyticsStoryHandler : IRequestHandler<ShowBookAnalyticsStoryContext, BooksAnalytics>
    {
        private readonly IMongoRepository _repository;

        public ShowBookAnalyticsStoryHandler(IMongoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<BooksAnalytics> Handle(ShowBookAnalyticsStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAsync(new ObjectId(request.Id));
            return item;
        }
    }
}
