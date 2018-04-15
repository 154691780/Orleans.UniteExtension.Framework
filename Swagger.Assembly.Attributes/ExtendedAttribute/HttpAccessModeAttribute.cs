using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 标记方法请求模式的标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class HttpAccessModeAttribute : Attribute
    {
        public HttpAccessMode HttpAccessMode { get; set; }

        public HttpAccessModeAttribute(HttpAccessMode m_HttpAccessMode = HttpAccessMode.post)
        {
            this.HttpAccessMode = m_HttpAccessMode;
        }
    }
}
