using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_GGG.Models
{
    public class AddCustomHeaderResourceFilter : IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            // Код, выполняемый перед действием
            context.HttpContext
                .Response
                .Headers
                .Add("X-Custom-Header", "MyCustomValue");
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // Код, выполняемый после действия
        }
    }
}
