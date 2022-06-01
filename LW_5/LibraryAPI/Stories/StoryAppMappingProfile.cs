using AutoMapper;
using LibraryAPI.Models.AnalyticsModels;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Models.UserModels;
using LibraryAPI.StoriesContexts.AnalyticsStoriesContexts.BookAnalyticsStoryContexts;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.BooksContexts;
using LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts;
using LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts;
using LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts;

namespace LibraryAPI.Stories
{
    public class StoryAppMappingProfile : Profile
    {
        public StoryAppMappingProfile()
        {
            CreateMap<AddBookStoryContext, Book>();
            CreateMap<UpdateBookStoryContext, Book>();
            CreateMap<AddSectionStoryContext, Section>();
            CreateMap<UpdateSectionStoryContext, Section>();
            CreateMap<AddUserStoryContext, User>();
            CreateMap<UpdateUserStoryContext, User>();
            CreateMap<AddBookmarkStoryContext, Bookmark>();
            CreateMap<UpdateBookmarkStoryContext, Bookmark>();
            CreateMap<AddBookAnalyticsStoryContext, BooksAnalytics>();
            CreateMap<UpdateBookAnalyticsStoryContext, BooksAnalytics>();
        }
    }
}
