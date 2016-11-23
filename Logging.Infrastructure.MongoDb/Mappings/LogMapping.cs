using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDomianModel;
using MongoDB.Bson.Serialization;

namespace Logging.Infrastructure.MongoDb.Mappings
{
    public class LogMapping: BsonClassMap
    {
        public LogMapping(Type classType) : base(classType)
        {
            RegisterClassMap<LogModel>(a => a.AutoMap());
        }

        public LogMapping(Type classType, BsonClassMap baseClassMap) : base(classType, baseClassMap)
        {
        }
    }
}
