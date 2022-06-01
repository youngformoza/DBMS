using MediatR;

namespace LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts
{
    public class AddBookAnalyticsStoryContext : IRequest<string>
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int? ReviewId { get; set; }
        public int? BookmarkId { get; set; }
        public DateTime? AdditionToBookmarkDate { get; set; }
        public DateTime? AdditionToQueue { get; set; }
        public DateTime? BorrowingDate { get; set; }
        public DateTime? DeadlineToReturn { get; set; }
        public DateTime? RemovingFromBookmarkDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
