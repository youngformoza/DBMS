using LibraryAPI.Models.BookModels;
using MediatR;

namespace LibraryAPI.StoriesContexts.SectionsContexts
{
    public class ShowAllSectionsStoryContext : IRequest<List<Section>>
    {
    }
}
