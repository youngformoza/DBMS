using AutoMapper;
using LibraryAPI.Models.BookModels;
using LibraryAPI.StoriesContexts.BooksContexts;
using LibraryAPI.StoriesContexts.SectionsContexts;

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
           
        }
    }
}
