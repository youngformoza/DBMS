using LibraryAPI.Models.UserModels;
using LibraryAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Stories.UserStories
{
    /*
    public class GetUsersByReviewsStory
    {
        private readonly IUserRepository _repository;

        public GetUsersByReviewsStory(IUserRepository repository)
        {
            _repository = repository;
        }


        public async Task<Dictionary<User, int>> Handle()
        {
            List<User> users = await _repository.GetAllAsync<User>();
            List<Review> reviews = await _repository.GetAllAsync<Review>();

            Dictionary<User, int> countReviewsDict = new Dictionary<User, int>();

            foreach (User user in users)
            {
                var founded = reviews.Where(x => x.UserId == user.Id).Select(x => x.Id);

                countReviewsDict.Add(user, founded.Count());
            }

            return countReviewsDict;
        }
    }
    */
}
