using Logging.Infrastructure.MongoDb.Mappings;
using LoggingDomianModel;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Logging.Infrastructure.MongoDb
{
    public interface ILoggingDbContext
    {
        IMongoCollection<LogModel> Logs { get; }
    }
    public class LoggingDbContext:ILoggingDbContext
    {
        private readonly string _connectionstring;
        private const string dbName = "Logging";
        private IMongoClient _client;
        private IMongoDatabase _database;

        public IMongoCollection<LogModel> Logs
        {
            get { return _database.GetCollection<LogModel>("Logs"); }
        }

        public LoggingDbContext(string connectionstring)
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof (LogMapping)))
            {
                BsonClassMap.RegisterClassMap(new LogMapping(typeof (LogMapping)));
            }
            _client = new MongoClient(connectionstring);
            _database = _client.GetDatabase(dbName);
        }
    }
}
