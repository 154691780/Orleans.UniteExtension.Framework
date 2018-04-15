using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// Http请求模式特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class HttpModeAttribute : Attribute
    {
        public HttpModeEnum HttpMode { get; private set; }

        /// <summary>
        /// Http请求模式特性
        /// </summary>
        /// <param name="m_HttpMode">Http模式</param>
        public HttpModeAttribute(HttpModeEnum m_HttpMode = HttpModeEnum.post)
        {
            this.HttpMode = m_HttpMode;
        }
    }
}
