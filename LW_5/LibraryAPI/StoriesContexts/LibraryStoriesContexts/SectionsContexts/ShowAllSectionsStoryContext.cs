using LibraryAPI.Models.BookModels;
using MediatR;

namespace LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts
{
    public class ShowAllSectionsStoryContext : IRequest<List<Section>>
    {
    }
}
