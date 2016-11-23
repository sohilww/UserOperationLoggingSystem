using System;
using LoggingDomianModel;
using UserOperationLoggingSystemService;

namespace Logging.Application
{
    public class LogWriter: ILogWriter
    {
        readonly ILogRepository _repository;
        public LogWriter(ILogRepository repository)
        {
            _repository = repository;
        }

        public void Write(LogModel model)
        {
            //Todo:Add Check Filters

            _repository.Save(model);
        }

      
    }
}
