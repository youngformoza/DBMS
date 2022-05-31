using library.Models.AnalyticsModels;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Repositories
{
    public interface IMongoRepository
    {
        public Task<BooksAnalytics> InsertAsync(BooksAnalytics record);

        public Task<List<BooksAnalytics>> GetAllAsync();

        public Task<BooksAnalytics> GetAsync(ObjectId id);

        public Task<bool> UpdateAsync(ObjectId id, BooksAnalytics record);

        public Task DeleteAsync(ObjectId id);

    }
}
