using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DI
{
    public class FileLogger : ILogger<FileLogger>
    {
        public string LogError()
        {
            return "from File Logger";
        }
    }
}
