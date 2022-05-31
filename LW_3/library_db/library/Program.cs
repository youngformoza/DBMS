using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.Repositories;
using System.Data.SqlClient;
using System.Configuration;
using library.Models;
using library.Stories.LibraryStories;
using library.Stories.UserStories;
using library.Models.UserModels;
using library.Models.BookModels;
using library.Models.AnalyticsModels;

namespace library
{
    class Program
    {
        static  async Task Main()
        {            
            IMongoRepository analyticsRepository = new MongoRepository();
            
            db_userContext userContext = new db_userContext();
            db_libraryContext libraryContext = new db_libraryContext();

            //IRepository user_repository = new UserRepository(userContext);
            IRepository libraryRepository = new Repository(libraryContext);
            IRepository userRepository = new Repository(userContext);

            var books = await analyticsRepository.GetAllAsync();

            foreach (var book in books)
            {
                Console.WriteLine(book.ReturnDate);
            } 

            /*
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 5, UserId = 8, BookmarkId = 33, ReturnDate = new DateTime(2022, 05, 09, 21, 56, 59), BorrowingDate = new DateTime(2022, 05, 02, 15, 36, 59), AdditionToBookmarkDate = new DateTime(2022, 04, 02, 22, 46, 59), RemovingFromBookmarkDate = new DateTime(2022, 07, 11, 15, 00, 00), DeadlineToReturn = new DateTime(2022, 05, 15, 15, 36, 59), AdditionToQueue = new DateTime(2022, 04, 28, 15, 15, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 8, UserId = 1, BookmarkId = 15, ReviewId = 9, ReturnDate = new DateTime(2021, 11, 22, 14, 45, 00), BorrowingDate = new DateTime(2021, 11, 02, 15, 36, 59),  DeadlineToReturn = new DateTime(2021, 12, 15, 15, 36, 59), AdditionToQueue = new DateTime(2021, 10, 28, 12, 15, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 6, UserId = 2, ReturnDate = new DateTime(2022, 03, 08, 21, 56, 59), BorrowingDate = new DateTime(2022, 02, 22, 11, 40, 00), DeadlineToReturn = new DateTime(2022, 04, 02, 21, 00, 00), AdditionToQueue = new DateTime(2022, 02, 11, 15, 15, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 4, UserId = 4, BookmarkId = 10, ReviewId = 4, ReturnDate = new DateTime(2020, 08, 09, 10, 00, 56), BorrowingDate = new DateTime(2020, 07, 22, 15, 36, 59), AdditionToBookmarkDate = new DateTime(2020, 04, 02, 22, 46, 59), DeadlineToReturn = new DateTime(2020, 09, 15, 21, 00, 00), AdditionToQueue = new DateTime(2020, 07, 28, 15, 15, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 7, UserId = 3, ReturnDate = new DateTime(2022, 01, 17, 14, 56, 59), BorrowingDate = new DateTime(2021, 12, 25, 15, 36, 59), DeadlineToReturn = new DateTime(2022, 05, 15, 15, 36, 59), AdditionToQueue = new DateTime(2022, 04, 28, 15, 15, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 4, UserId = 2, BookmarkId = 28, ReviewId = 11, AdditionToBookmarkDate = new DateTime(2022, 03, 02, 22, 46, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 6, UserId = 5, BookmarkId = 12, ReviewId = 27, AdditionToBookmarkDate = new DateTime(2021, 02, 02, 22, 46, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 9, UserId = 8,ReturnDate = new DateTime(2022, 05, 09, 21, 56, 59), BorrowingDate = new DateTime(2022, 05, 02, 15, 36, 59), DeadlineToReturn = new DateTime(2022, 05, 15, 15, 36, 59), AdditionToQueue = new DateTime(2022, 04, 28, 15, 15, 59) });
            await analyticsRepository.InsertAsync(new BooksAnalytics { BookId = 1, UserId = 1, BookmarkId = 11, ReturnDate = new DateTime(2022, 02, 15, 21, 56, 59), BorrowingDate = new DateTime(2022, 01, 17, 15, 36, 59), AdditionToBookmarkDate = new DateTime(2020, 02, 02, 22, 46, 59), RemovingFromBookmarkDate = new DateTime(2022, 07, 11, 15, 00, 00), DeadlineToReturn = new DateTime(2022, 03, 01, 21, 00, 00), AdditionToQueue = new DateTime(2021, 12, 28, 15, 15, 59) });
            */
            /*User user = await user_repository.GetAsync<User>(2);

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



            BooksAnalytics genre = await library_repository.GetAsync<BooksAnalytics>(1);
            Console.WriteLine(genre.BookName);

            GetBooksToGenresStory libStory = new GetBooksToGenresStory(library_repository);
            GetUsersByReviewsStory userStory = new GetUsersByReviewsStory(user_repository);

            //var dictLib = await libStory.Handle();
            var dictUser = await userStory.Handle();

            //Console.WriteLine("bu");
            */
        }
    }
}