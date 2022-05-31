using LibraryAPI.Models.BookModels;
using LibraryAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Stories.LibraryStories
{
    public class GetBooksToGenresStory
    {
        private readonly IUserRepository _repository;

        public GetBooksToGenresStory(IUserRepository repository)
        {
            _repository = repository;
        }

        
        public async Task<Dictionary<Genre, int>> Handle()
        {
            List<Genre> genres = await _repository.GetAllAsync<Genre>();
            List<GenreToBook> genresToBooks = await _repository.GetAllAsync<GenreToBook>();

            Dictionary<Genre, int> countGenresDict = new Dictionary<Genre, int>();

            foreach (Genre genre in genres)
            {
                var founded = genresToBooks.Where(x => x.GenreId == genre.Id).Select(x => x.Id);
                
                countGenresDict.Add(genre, founded.Count());
            }

            return countGenresDict;
        }
        
    }
}
