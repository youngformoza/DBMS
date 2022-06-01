using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAPI.Models.AnalyticsModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace LibraryAPI.Repositories
{
    public class MongoRepository : IMongoRepository
    {
        private static IMongoDatabase Db;
        private readonly string _connection;
        private readonly MongoClient _client;
        private readonly IMongoCollection <BooksAnalytics> _collection;

        public MongoRepository()
        {
           _client = new MongoClient("mongodb://localhost:27017");
            Db = _client.GetDatabase("Analytics");
            _collection = Db.GetCollection<BooksAnalytics>("Book");
        }

        public async Task<string> InsertAsync(BooksAnalytics record)
        {
            await _collection.InsertOneAsync(record);

            return record.Id;
        }

        public async Task<List<BooksAnalytics>> GetAllAsync()
        {
            var filter = Builders<BooksAnalytics>.Filter.Empty;
            var res = await _collection.FindAsync<BooksAnalytics>(filter);

            return await res.ToListAsync();
        }

        public async Task<BooksAnalytics> GetAsync(ObjectId id)
        {
            var filter = Builders<BooksAnalytics>.Filter.Eq("Id", id);
            var res = await _collection.Find(filter).SingleOrDefaultAsync();

            return res;
        }

        public async Task<bool> UpdateAsync(ObjectId id, BooksAnalytics record)
        {
            var res = await _collection.ReplaceOneAsync(new BsonDocument("_id", id), record, new ReplaceOptions { IsUpsert = true });
            
            return res.IsAcknowledged && res.ModifiedCount > 0;
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<BooksAnalytics>.Filter.Eq("Id", id);
            var res = await _collection.DeleteOneAsync(filter);
        }
    }
}
