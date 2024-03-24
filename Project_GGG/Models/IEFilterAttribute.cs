using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyModel;
using System.Text.RegularExpressions;

namespace Project_GGG.Models
{
    public class IEFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            //получаем информацию о браузере польз
            string userAgent = context.HttpContext.Request.Headers
                ["User-Agent"].ToString();
            if (Regex.IsMatch(userAgent, "MSIE|Trident"))
            {
                context.Result = new ContentResult
                {
                    Content = "Ваш брацзер устарел"
                };
            }
        }
    }
}
