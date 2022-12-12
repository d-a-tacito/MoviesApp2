using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using MoviesApp.Controllers;
using MoviesApp.Data;
using MoviesApp.Middleware;
using MoviesApp.Models;
using MoviesApp.ViewModels;

namespace MoviesApp.Middleware
{
    public class ActorLogMiddleware
    {
        private readonly RequestDelegate _next;

        public ActorLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ILogger<ActorLogMiddleware> logger)
        {
            if (httpContext.Request.Path.Equals("/Actors"))
            {
                logger.LogInformation("OPENED ACTORS' LIST\n"+$"Request: {httpContext.Request.Path}  Method: {httpContext.Request.Method}");
            }
            else if (httpContext.Request.Path.Equals("/Actors/Index"))
            {
                logger.LogInformation("OPENED ACTORS' LIST INDEX\n"+$"Request: {httpContext.Request.Path}  Method: {httpContext.Request.Method}");
            }
            await _next(httpContext);
        }
    }
}