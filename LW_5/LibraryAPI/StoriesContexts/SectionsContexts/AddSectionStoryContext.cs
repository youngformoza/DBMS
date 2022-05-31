using MediatR;

namespace LibraryAPI.StoriesContexts.SectionsContexts
{
    public class AddSectionStoryContext : IRequest<int>
    {
        public string SectionName { get; set; }
    }
}
