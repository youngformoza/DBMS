using LibraryAPI.Models.AnalyticsModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts;
using MediatR;
using MongoDB.Driver;

namespace LibraryAPI.Stories.AnalyticsStories.BookAnalyticsStories
{
    public class ShowAllBooksAnalyticsStoryHandler : IRequestHandler<ShowAllBooksAnalyticsStoryContext, List<BooksAnalytics>>
    {
        //private readonly ILibraryRepository _repository;
        private readonly IMongoRepository _repository;

        public ShowAllBooksAnalyticsStoryHandler(IMongoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<BooksAnalytics>> Handle(ShowAllBooksAnalyticsStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync();

            return item.ToList();
        }
    }
}
