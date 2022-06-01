using LibraryAPI.Models.AnalyticsModels;
using MediatR;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts
{
    public class ShowBookAnalyticsStoryContext : IRequest<BooksAnalytics>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public string Id { get; set; }

    }
}
