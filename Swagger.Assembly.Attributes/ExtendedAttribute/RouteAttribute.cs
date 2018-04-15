using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlyUsed.Toolkit;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 方法路由特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class RouteAttribute : Attribute
    {
        public string RoutePath { get; private set; }

        public RouteAttribute(string m_RoutePath)
        {
            if (!m_RoutePath.StartsWith("/"))
            {
                throw new System.ArgumentException("路由路径不是以 / 符号开头.", "m_RoutePath");
            }

            if (m_RoutePath.StrIsNullOrEmpty())
            {
                throw new System.ArgumentNullException("m_RoutePath", "路由路径为Empty或Null.");
            }

            this.RoutePath = m_RoutePath;
        }
    }
}
