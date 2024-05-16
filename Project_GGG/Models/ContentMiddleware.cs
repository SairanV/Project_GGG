namespace Project_GGG.Models
{
    public class ContentMiddleware
    {
        private RequestDelegate nextDelegate;
        public ContentMiddleware(RequestDelegate next) 
        { 
            nextDelegate = next; 
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Path.ToString() == "/middleware")
            {
                await context.Response.WriteAsync("This is from the content middleware");
            }
            else
            {
                await nextDelegate.Invoke(context);
            }
        }
    }
}
