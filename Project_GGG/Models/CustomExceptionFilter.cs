using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_GGG.Models
{
    public class CustomExceptionFilter : Attribute, IExceptionFilter
    {
        private readonly ILogger<CustomExceptionFilter> _logger;

        //public CustomExceptionFilter(ILogger<CustomExceptionFilter> logger)
        //{
        //    _logger = logger;
        //}

        public void OnException(ExceptionContext context)
        {
            // Регистрируем исключение
            //_logger.LogError($"An exception occurred: {context.Exception.Message}");

            // Обрабатываем исключение
            context.Result = new ViewResult { ViewName = "Error" };
            context.ExceptionHandled = true;
        }
    }
}
