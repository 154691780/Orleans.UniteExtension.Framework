using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swagger.Assembly.Attributes.ExtendedAttribute;
using System.Collections.Concurrent;
using CommonlyUsed.Toolkit;

namespace Swagger.Specification.Provider
{
    /// <summary>
    /// 生成服务供应商
    /// </summary>
    public class GenerationDocProvider //: IServiceProvider
    {
        //public object GetService(Type serviceType)
        //{
        //    return serviceType;
        //}

        public static ConcurrentDictionary<string, MethodInfo> AssemblyMethodCacheDicy { get; private set; }

        static GenerationDocProvider()
        {
            GenerationDocProvider.AssemblyMethodCacheDicy = new ConcurrentDictionary<string, MethodInfo>();
        }

        public static void CreationAssemblyMethodCache(string m_AssemblyFullName)
        {
            var m_LoadAssembly = System.Reflection.Assembly.LoadFrom(m_AssemblyFullName);

            foreach (var m_Item in m_LoadAssembly.GetTypes().SelectMany(o => o.GetMethods()))
            {
                var m_IsRouteAttribute = m_Item.GetCustomAttributes().SingleOrDefault(o => o.GetType() == typeof(RouteAttribute));
                if (m_IsRouteAttribute != null)
                {
                    var m_RefVersionAttribute = m_Item.GetCustomAttribute<RefVersionAttribute>();
                    string m_RefVersionStr = m_RefVersionAttribute.RefVersion;

                    var m_HttpModeAttribute = m_Item.GetCustomAttribute<HttpModeAttribute>();
                    string m_HttpModeStr = m_HttpModeAttribute.HttpMode.ToString();

                    string m_RoutePath = (m_IsRouteAttribute as RouteAttribute).RoutePath;

                    // Key格式[/RefVersionAttribute/HttpModeAttribute/RouteAttribute]
                    string m_RouteKey = string.Format("{0}/{1}{2}", m_RefVersionStr, m_HttpModeStr, m_RoutePath);
                    var m_IsAdd = AssemblyMethodCacheDicy.ExtendedTryAdd(m_RouteKey, m_Item);

                    System.Diagnostics.Debug.WriteLine(string.Format("RouteKey是否加入成功:{0};  RouteKey: [ {1} ]; MethodName: {2}", m_IsAdd, m_RouteKey, m_Item.Name));
                }
            }
        }

        public static string GenerationDocument(string m_AssemblyFullName)
        {
            foreach (var m_Item in GenerationDocProvider.AssemblyMethodCacheDicy)
            {

            }

            return "";
        }
    }
}
