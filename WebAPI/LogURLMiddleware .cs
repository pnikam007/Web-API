using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class LogURLMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LogURLMiddleware> _logger;

        public LogURLMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)        {
            _next = next;
            _logger = loggerFactory?.CreateLogger<LogURLMiddleware>() ?? throw new ArgumentNullException(nameof(loggerFactory));   
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("Error");
            await _next(context);
        }
    }


    public static class LogURLMiddlewareExt
    {
        public static IApplicationBuilder UseLogURL(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LogURLMiddleware>();
        }
    }
}
