using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using MediatR;
using System.ComponentModel.DataAnnotations;


namespace LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts
{
    public class DeleteSectionStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }

    }
}
