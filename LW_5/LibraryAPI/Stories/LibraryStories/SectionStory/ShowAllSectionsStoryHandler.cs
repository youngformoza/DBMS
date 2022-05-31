using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.SectionStory
{
    public class ShowAllSectionsStoryHandler : IRequestHandler<ShowAllSectionsStoryContext, List<Section>>
    {
        private readonly ILibraryRepository _repository;

        public ShowAllSectionsStoryHandler(ILibraryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<Section>> Handle(ShowAllSectionsStoryContext request,
            CancellationToken cancellationToken)
        {
            var item = await _repository.GetAllAsync<Section>();

            return item.ToList();
        }
    }
}
