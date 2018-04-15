using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 方法返回Http编码特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodResponsesAttribute : Attribute
    {
        public string RespCode { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }

        /// <summary>
        /// 方法返回Http编码特性
        /// </summary>
        /// <param name="m_RespCode">
        /// 返回Http编码
        /// <para>http://www.runoob.com/http/http-status-codes.html</para>
        /// </param>
        /// <param name="m_Description">返回描述</param>
        public MethodResponsesAttribute(string m_RespCode = "default", string m_Description = "")
        {
            this.RespCode = m_RespCode;
            this.Description = m_Description;
        }
    }
}
