using System;

namespace LoggingDomianModel
{
    public interface ILogRepository
    {
        void Save(LogModel current); 
    }
}