using MongoDB.Driver;

namespace FirebaseJob.Contexts
{
    public static class MongoDBFactory
    {
        public static MongoClient CreateClient(string connectionString) => new MongoClient(connectionString);
    }
}