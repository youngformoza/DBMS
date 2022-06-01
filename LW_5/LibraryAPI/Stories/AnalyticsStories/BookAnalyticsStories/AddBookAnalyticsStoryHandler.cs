using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models.AnalyticsModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts;
using MediatR;

namespace LibraryAPI.Stories.AnalyticsStories.BookAnalyticsStories
{
    public class AddBookAnalyticsStoryHandler : IRequestHandler<AddBookAnalyticsStoryContext, string>
    {
        private readonly IMongoRepository _repository;
        private readonly IMapper _mapper;

        public AddBookAnalyticsStoryHandler(IMongoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<string> Handle(AddBookAnalyticsStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new BooksAnalytics());

            return await _repository.InsertAsync(asteroid);
        }
    }
}
