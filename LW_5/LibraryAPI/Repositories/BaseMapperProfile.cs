using AutoMapper;
using LibraryAPI.Models.AnalyticsModels;
using LibraryAPI.Models.BookModels;
using LibraryAPI.Models.UserModels;

namespace LibraryAPI.Repositories
{
    public class BaseMapperProfile : Profile
    {
        public BaseMapperProfile()
        {
            CreateMap<Book, Book>();
            CreateMap<Section, Section>();
            CreateMap<User, User>();
            CreateMap<Bookmark, Bookmark>();
            CreateMap<BooksAnalytics, BooksAnalytics>();
        }
    }
}
