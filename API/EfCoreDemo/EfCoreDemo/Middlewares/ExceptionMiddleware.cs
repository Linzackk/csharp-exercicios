using EfCoreDemo.Exceptions;
using Microsoft.AspNetCore.Http;

namespace EfCoreDemo.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Invocando Middleware!!!");
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocorreu um erro não tratado.");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            int statusCode = StatusCodes.Status500InternalServerError;
            string message = "Ocorreu um Erro no servidor.";

            if (ex is ProdutoNotFound)
            {
                statusCode = StatusCodes.Status404NotFound;
                message = ex.Message;
            }
            else if (ex is ArgumentException)
            {
                statusCode = StatusCodes.Status400BadRequest;
                message = ex.Message;
            }

            context.Response.StatusCode = statusCode;
            var result = System.Text.Json.JsonSerializer.Serialize(new
            {
                error = message,
                status = statusCode
            });

            return context.Response.WriteAsync(result);
        }
    }
}
