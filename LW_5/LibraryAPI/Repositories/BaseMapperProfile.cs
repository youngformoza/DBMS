using AutoMapper;
using LibraryAPI.Models.BookModels;

namespace LibraryAPI.Repositories
{
    public class BaseMapperProfile : Profile
    {
        public BaseMapperProfile()
        {
            CreateMap<Book, Book>();
            CreateMap<Section, Section>();
        }
    }
}
