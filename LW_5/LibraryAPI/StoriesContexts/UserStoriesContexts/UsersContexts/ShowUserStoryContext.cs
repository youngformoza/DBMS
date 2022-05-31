using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.StoriesContexts.UserStoriesContexts.UsersContexts
{
    public class ShowUserStoryContext : IRequest<User>
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int Id { get; set; }

    }

}
