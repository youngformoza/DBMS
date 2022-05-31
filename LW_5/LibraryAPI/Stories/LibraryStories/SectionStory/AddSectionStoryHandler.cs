using AutoMapper;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.SectionsContexts;
using MediatR;

namespace LibraryAPI.Stories.LibraryStories.SectionStory
{
    public class AddSectionStoryHandler : IRequestHandler<AddSectionStoryContext, int>
    {
        private readonly ILibraryRepository _repository;
        private readonly IMapper _mapper;

        public AddSectionStoryHandler(ILibraryRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<int> Handle(AddSectionStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new Section());

            return await _repository.InsertAsync(asteroid);
        }
    }
}
