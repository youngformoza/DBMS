using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Analytics
{
    partial class Program
    {
        public class MongoDbRepository
        {
            private static IMongoDatabase db;

            public static void Insert(Book record)
            {
                string connection = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
                var client = new MongoClient(connection);
                db = client.GetDatabase("Analytics");
                var collection = db.GetCollection<Book>("Book");
                collection.InsertOne(record);

            }

            public static List<Book> Read<Book>()
            {
                string connection = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
                var client = new MongoClient(connection);
                db = client.GetDatabase("Analytics");
                var collection = db.GetCollection<Book>("Book");
                var res = collection.Find<Book>(_ => true).ToList();
                // var res = collection.Find(new BsonDocument()).Project("{Id:0}").ToList();
                //var test = res.Select(v => BsonSerializer.Deserialize<Book>(v)).ToList();
                //collection.Find(new BsonDocument()).ToList();

                return res;

            }

            public static Book ReadbyId<Book>(ObjectId id)
            {
                string connection = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
                var client = new MongoClient(connection);
                db = client.GetDatabase("Analytics");
                var collection = db.GetCollection<Book>("Book");
                var filter = Builders<Book>.Filter.Eq("Id",id);
                var res = collection.Find(filter).First();
               

                return res;

            }

            public static void Update<Book>(ObjectId id, Book record)
            {
                string connection = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
                var client = new MongoClient(connection);
                db = client.GetDatabase("Analytics");
                var collection = db.GetCollection<Book>("Book");
                var res = collection.ReplaceOne(new BsonDocument("_id", id), record, new UpdateOptions { IsUpsert = true });

            }

            public static void Delete<Book>(ObjectId id)
            {
                string connection = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
                var client = new MongoClient(connection);
                db = client.GetDatabase("Analytics");
                var collection = db.GetCollection<Book>("Book");
                var filter = Builders<Book>.Filter.Eq("Id", id);
                collection.DeleteOne(filter);

            }
        }
    }
}

