using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Project_GGG.Models
{
    public class TimeElapsed : Attribute, IActionFilter
    {
        private Stopwatch timer;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Инициализация и запуск таймера перед выполнением действия
            timer = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Остановка таймера после выполнения действия
            timer.Stop();

            string result = "ElapsedTime: " + $"{timer.ElapsedMilliseconds}ms";

            // Опционально: Вывод результата в лог или другой механизм
            Debug.WriteLine(result);
        }
    }
}
