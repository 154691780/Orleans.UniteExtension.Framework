using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 标记方法描述(Desc)的标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodDescAttribute : Attribute
    {
        public string Summary { get; set; }
        public string Description { get; set; }
        public string OperationId { get; set; }

        public MethodDescAttribute(string m_Summary, string m_Description, string m_OperationId)
        {
            this.Summary = m_Summary;
            this.Description = m_Description;
            this.OperationId = m_OperationId;
        }
    }
}
