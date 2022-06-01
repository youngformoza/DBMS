using MediatR;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts
{
    public class DeleteBookAnalyticsStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]

        public string Id { get; set; }
    }
}
