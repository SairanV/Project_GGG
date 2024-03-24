using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Project_GGG.Models
{
    public class TimeElapsed : Attribute, IActionFilter
    {
        private Stopwatch timer;




        public void OnActionExecuted(ActionExecutedContext context)
        {
            timer = Stopwatch.StartNew();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            timer.Stop();

            string result = "ElapsedTime: " + 
                $"{timer.ElapsedMilliseconds}ms";
        }
    }
}
