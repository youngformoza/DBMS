using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using MediatR;
using System.ComponentModel.DataAnnotations;


namespace LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts
{
    public class DeleteBookmarkStoryContext : IRequest<bool>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }

    }
}
