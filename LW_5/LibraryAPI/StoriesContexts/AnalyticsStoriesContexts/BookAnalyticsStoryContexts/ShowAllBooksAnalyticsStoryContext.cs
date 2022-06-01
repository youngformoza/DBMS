using LibraryAPI.Models.AnalyticsModels;
using MediatR;

namespace LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts
{
    public class ShowAllBooksAnalyticsStoryContext : IRequest<List<BooksAnalytics>>
    {
    }
}
