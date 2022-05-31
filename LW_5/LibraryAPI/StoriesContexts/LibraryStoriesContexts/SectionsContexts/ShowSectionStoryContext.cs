using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.StoriesContexts.LibraryStoriesContexts.SectionsContexts
{
    public class ShowSectionStoryContext : IRequest<Section>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }

    }

}
