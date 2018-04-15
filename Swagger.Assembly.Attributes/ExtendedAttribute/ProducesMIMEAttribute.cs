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
    /// 产生MIME类型特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ProducesMIMEAttribute : Attribute
    {
        public MIMETypeEnum[] Produces { get; private set; }

        /// <summary>
        /// 产生MIME类型特性
        /// </summary>
        /// <param name="m_Produces">产生MIME类型数组</param>
        public ProducesMIMEAttribute(params MIMETypeEnum[] m_Produces)
        {
            this.Produces = m_Produces;
        }

        public override string ToString()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("[");
            foreach (var m_Item in Produces)
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
