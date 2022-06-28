using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DI
{
    public class DbLogger : ILogger<DbLogger>
    {
        public string LogError()
        {
            return "From DB Logger";
        }
    }
}
