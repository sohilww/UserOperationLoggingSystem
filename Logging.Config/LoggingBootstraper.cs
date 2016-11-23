using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging.Application;
using Logging.Infrastructure.MongoDb;
using LoggingDomianModel;
using Ninject;
using Ninject.Web.Common;
using UserOperationLoggingSystemService;

namespace Logging.Config
{
    public static class LoggingBootstraper
    {
        public static void Bootstrap(string connectionString,StandardKernel kernel=null)
        {
            if (kernel == null)
            {
                kernel=new StandardKernel();
            }

            kernel.Bind<ILoggingDbContext>()
                .To<LoggingDbContext>()
                .InSingletonScope()
                .WithConstructorArgument("connectionstring", connectionString);

            kernel.Bind<ILogRepository>()
                .To<LogRepository>()
                .InRequestScope();


            kernel.Bind<ILogWriter>().To<LogWriter>()
                .InRequestScope();



        }
    }
    
}
