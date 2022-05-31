using MediatR;

namespace LibraryAPI.StoriesContexts.SectionsContexts
{
    public class UpdateSectionStoryContext : IRequest<bool>
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
    }
}
