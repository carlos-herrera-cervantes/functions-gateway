using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FirebaseJob.Contexts;
using FirebaseJob.Models;
using MongoDB.Driver;

namespace FirebaseJob.Managers
{
    public class Manager<T> : IManager<T> where T : BaseEntity
    {
        private readonly IMongoCollection<T> _context;

        public Manager()
        {
            var client = MongoDBFactory
                .CreateClient(Environment.GetEnvironmentVariable("MongoDBConnectionString"));

            _context = client
                .GetDatabase(Environment.GetEnvironmentVariable("MongoDBDatabase"))
                .GetCollection<T>($"{typeof(T).Name}s");
        }
        
        public async Task CreateManyAsync(IEnumerable<T> documents)
            => await _context.InsertManyAsync(documents);
    }
}