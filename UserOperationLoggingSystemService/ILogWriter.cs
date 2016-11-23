using LoggingDomianModel;

namespace UserOperationLoggingSystemService
{
    public interface ILogWriter
    {
        void Write(LogModel model);
    }
}