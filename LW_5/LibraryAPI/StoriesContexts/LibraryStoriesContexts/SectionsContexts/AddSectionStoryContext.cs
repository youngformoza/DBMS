using MediatR;

namespace LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts
{
    public class AddSectionStoryContext : IRequest<int>
    {
        public string SectionName { get; set; }
    }
}
