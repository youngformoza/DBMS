using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.StoriesContexts.UserStoriesContexts.BookmarkContexts
{
    public class ShowBookmarkStoryContext : IRequest<Bookmark>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }

    }

}
