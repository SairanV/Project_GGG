using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_GGG.Models
{
    public class ChangeView : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
          
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.Result = new ViewResult
            {
                ViewName = "Login"
            };
        }
    }
}
