using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Orleans.Middlewares
{
    public class SwaggerGenerateDocManager : OwinMiddleware
    {
        public SwaggerGenerateDocManager(OwinMiddleware next) : base(next)
        {
        }

        public async override Task Invoke(IOwinContext context)
        {
            Console.WriteLine("SwaggerGenerateDocManager Start.");



            Console.WriteLine("SwaggerGenerateDocManager End.");
            await Next.Invoke(context);
        }


        public static Task SwaggerGenerateDoc(IOwinContext context, Func<Task> func)
        {
            Console.WriteLine("UrlPath: {0}", context.Request.Path);

            return func();
        }
    }
}
