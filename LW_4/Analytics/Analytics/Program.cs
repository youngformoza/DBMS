using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace Analytics
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Find_book();
            //Insert_book();
            //Find_book_by_Id();
            //Update_book();
            Delete_book();
        }


        static void Insert_book()
        {
            MongoDbRepository.Insert(
                new Book 
                { 
                    book_id = 7, 
                    user_id = 6, 
                    bookmark = 33, 
                    return_date = new DateTime(2022, 05, 09, 21, 56, 59)
                }
            );
        }

        static void Find_book()
        {
            var records = MongoDbRepository.Read<Book>();

            records.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });

        }

        static void Update_book()
        {
            var rec = MongoDbRepository.ReadbyId<Book>(new ObjectId("6273eedb4d0c19cd49a5b6e4"));
            rec.borrowing_date = new DateTime(2022, 05, 09, 21, 56, 59);
            MongoDbRepository.Update(rec.Id, rec);

        }

        static void Find_book_by_Id()
        {
            var rec = MongoDbRepository.ReadbyId<Book>(new ObjectId("6273eedb4d0c19cd49a5b6e4"));
            Console.WriteLine(rec.book_id);
        }

        static void Delete_book()
        {
            var rec = MongoDbRepository.ReadbyId<Book>(new ObjectId("6273eedb4d0c19cd49a5b6e4"));
            MongoDbRepository.Delete<Book>(rec.Id);
        }
    }
}
