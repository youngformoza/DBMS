using MediatR;

namespace LibraryAPI.StoriesContexts.BooksContexts
{
    public class UpdateBookStoryContext : IRequest<bool>
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        public int? BookCount { get; set; }

        public string BookDescription { get; set; }

        public int? BookAgeRestriction { get; set; }

        public int StatusId { get; set; }

        public int SectionId { get; set; }
    }
}
