using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.Repositories;
using library.Entities;
using System.Data.SqlClient;
using System.Configuration;
using library.Models;
using library.Stories.LibraryStories;
using library.Stories.UserStories;

namespace library
{
    class Program
    {
        static  async Task Main()
        {
            db_userContext userContext = new db_userContext();
            db_libraryContext libraryContext = new db_libraryContext();

            //IRepository user_repository = new UserRepository(userContext);
            IRepository library_repository = new Repository(libraryContext);
            IRepository user_repository = new Repository(userContext);

            User user = await user_repository.GetAsync<User>(2);

            Console.WriteLine(user.UserLogin);
            Console.WriteLine(user.UserNickname);

            
            User user_new = new User();
            Console.WriteLine("Enter user login");
            user_new.UserLogin = Console.ReadLine();
            Console.WriteLine("Enter user nickname");
            user_new.UserNickname = Console.ReadLine();
            Console.WriteLine("Enter user password");
            user_new.UserPassword = Console.ReadLine();
            Console.WriteLine("Enter user role id");
            user_new.RoleId = Int32.Parse(Console.ReadLine());

            User user_inserted = await user_repository.InsertAsync<User>(user_new);



            Book genre = await library_repository.GetAsync<Book>(1);
            Console.WriteLine(genre.BookName);

            GetBooksToGenresStory libStory = new GetBooksToGenresStory(library_repository);
            GetUsersByReviewsStory userStory = new GetUsersByReviewsStory(user_repository);

            //var dictLib = await libStory.Handle();
            var dictUser = await userStory.Handle();

            //Console.WriteLine("bu");
        }
    }
}