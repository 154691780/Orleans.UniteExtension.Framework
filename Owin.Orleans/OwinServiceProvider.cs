using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Owin.Swagger.GenerateDoc;
using System.Collections.Concurrent;

namespace Owin.Orleans
{
    /// <summary>
    /// 启动Owin服务
    /// </summary>
    public class OwinServiceStartup
    {
        public IDictionary<string, object> ConfigDicty { get; private set; }

        //public static ConcurrentDictionary<string, System.Reflection.MethodInfo> RouterMapMethodCacheDicy { get; private set; }

        public OwinServiceStartup(IDictionary<string, object> m_ConfigDicty)
        {
            this.ConfigDicty = m_ConfigDicty;
        }

        public void Configure(IAppBuilder app)
        {
            //app.UseCors(CorsOptions.AllowAll);

            //app.Use(Middlewares.SwaggerGenerateDocManager.SwaggerGenerateDoc);
            //app.UseSwaggerGenerateDoc();    // 生成Swagger文档
        }
    }
}