using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 标记方法返回信息的标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodResponsesAttribute : Attribute
    {
        public string RespCode { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }

        public MethodResponsesAttribute(string m_Description, string m_Schema, string m_RespCode = "default")
        {
            this.RespCode = m_RespCode;
            this.Description = m_Description;
            this.Schema = m_Schema;
        }
    }
}
