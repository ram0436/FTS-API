using FTS.API.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FTS.API.Middlewares
{ 
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        ILogger<ExceptionMiddleware> _logger;
       private readonly IHostEnvironment _env;
        public ExceptionMiddleware(IHostEnvironment env, RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                ApiError response;
                HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
                string message;
                var exceptionType = ex.GetType();

                if(exceptionType==typeof(UnauthorizedAccessException))
                {
                    statusCode = HttpStatusCode.Forbidden;
                    message = "You are not authorized";
                }
               else if (exceptionType == typeof(BadHttpRequestException))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    message = "Bad Request";
                }
                else
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    message = "some unknown error occured";
                }


                if(_env.IsDevelopment())
                {
                    response = new ApiError((int)statusCode, ex.Message, ex.StackTrace.ToString());
                }
                else
                {
                    response = new ApiError((int)statusCode, message);
                }

                _logger.LogError(ex, ex.Message);
                context.Response.StatusCode = (int)statusCode;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(response.ToString());
            }
        }
    }
}
