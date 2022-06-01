using AutoMapper;
using LibraryAPI.Models.AnalyticsModels;
using LibraryAPI.Repositories;
using LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts;
using MediatR;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryAPI.Stories.AnalyticsStories.BookAnalyticsStories
{
    public class UpdateBookAnalyticsStoryHandler : IRequestHandler<UpdateBookAnalyticsStoryContext, bool>
    {
        private readonly IMongoRepository _repository;
        private readonly IMapper _mapper;
        public UpdateBookAnalyticsStoryHandler(IMongoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateBookAnalyticsStoryContext request,
            CancellationToken cancellationToken)
        {
            var asteroid = _mapper.Map(request, new BooksAnalytics());
            var response = await _repository.UpdateAsync(new ObjectId(asteroid.Id), asteroid);

            return response;
        }
    }
}
