using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDomianModel;

namespace Logging.Infrastructure.MongoDb
{
    public class LogRepository:ILogRepository
    {
        private readonly ILoggingDbContext _context;
        public LogRepository(ILoggingDbContext context)
        {
            _context = context;
        }

        public void Save(LogModel current)
        {
            _context.Logs.InsertOneAsync(current);
        }
    }
}
