using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DI
{
    public interface ILogger<T> where T : class
    {
        string LogError();
    }

    public enum LoggerType
    {
        DbLogger,
        FileLogger
    }
}
