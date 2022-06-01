using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.SectionStory
{
    public class UpdateSectionStoryHandler : IRequestHandler<UpdateSectionStoryContext, bool>
    {
        private readonly IRepository<DbLibraryContext> _repository;
        private readonly IMapper _mapper;

        public UpdateSectionStoryHandler(IRepository<DbLibraryContext> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateSectionStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Section());
            var response = await _repository.UpdateAsync(asteroid);

            return response;
        }
    }
}
