using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Analytics
{
    [BsonIgnoreExtraElements]
    public class Book
    {
        public ObjectId Id { get; set; }
        public dynamic book_id { get; set; }
        public dynamic user_id { get; set; }
        public dynamic? review { get; set; }
        public dynamic? bookmark { get; set; }
        [DataMember]
        public DateTime? addition_to_bookmark_date { get; set; }
        [DataMember]
        public DateTime? addition_to_queue { get; set; }
        [DataMember]
        public DateTime? borrowing_date { get; set; }
        [DataMember]
        public DateTime? deadline_to_return { get; set; }
        [DataMember]
        public DateTime? removing_from_bookmark_date { get; set; }
        [DataMember]
        public DateTime? return_date { get; set; }
    }
}
