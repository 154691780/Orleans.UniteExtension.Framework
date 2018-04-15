using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 标记方法路由的标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class RouteAttribute : Attribute
    {
        public string BasePath { get; set; }
        public string RouteUrlPath { get; set; }
        public string[] Tags { get; set; }

        public RouteAttribute(string m_BasePath, string m_RouteUrlPath, params string[] m_Tags)
        {
            this.BasePath = m_BasePath;
            if (!string.IsNullOrEmpty(m_BasePath))
            {
                m_BasePath = "/v1";
            }

            this.RouteUrlPath = m_RouteUrlPath;
            this.Tags = m_Tags;
        }
    }
}
