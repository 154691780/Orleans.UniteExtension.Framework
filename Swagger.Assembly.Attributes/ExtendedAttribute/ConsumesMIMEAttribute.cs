using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlyUsed.Toolkit;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    /// <summary>
    /// 消费MIME类型特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ConsumesMIMEAttribute : Attribute
    {
        public MIMETypeEnum[] Consumes { get; private set; }

        /// <summary>
        /// 消费MIME类型特性
        /// </summary>
        /// <param name="m_Consumes">消费MIME类型数组</param>
        public ConsumesMIMEAttribute(params MIMETypeEnum[] m_Consumes)
        {
            this.Consumes = m_Consumes;
        }

        public override string ToString()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("[");
            foreach (var m_Item in Consumes)
            {
                m_Return.AppendFormat("\"{0}\",", m_Item.GetEnumDescription());
            }
            m_Return.Append("]");

            return m_Return.ToString();
        }

        public string ToJsonString()
        {
            return this.ToString();
        }
    }
}
