using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.StoriesContexts.LibraryStoriesContexts.BooksContexts
{
    public class ShowBookStoryContext : IRequest<Book>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }

    }

}
