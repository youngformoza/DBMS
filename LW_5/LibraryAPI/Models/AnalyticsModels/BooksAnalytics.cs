using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Models.AnalyticsModels
{
    [BsonIgnoreExtraElements]
    public class BooksAnalytics
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("book_id")]
        public int BookId { get; set; }

        [BsonElement("user_id")]
        public int UserId { get; set; }

        [BsonElement("review_id")]
        public int? ReviewId { get; set; }

        [BsonElement("bookmark_id")]
        public int? BookmarkId { get; set; }
        
        [DataMember]
        [BsonElement("addition_to_bookmark_date")]
        public DateTime? AdditionToBookmarkDate { get; set; }
        
        [DataMember]
        [BsonElement("addition_to_queue")]
        public DateTime? AdditionToQueue { get; set; }
        
        [DataMember]
        [BsonElement("borrowing_date")]
        public DateTime? BorrowingDate { get; set; }
        
        [DataMember]
        [BsonElement("deadline_to_return")]
        public DateTime? DeadlineToReturn { get; set; }
       
        [DataMember]
        [BsonElement("removing_from_bookmark_date")]
        public DateTime? RemovingFromBookmarkDate { get; set; }
        
        [DataMember]
        [BsonElement("return_date")]
        public DateTime? ReturnDate { get; set; }
    }
}
