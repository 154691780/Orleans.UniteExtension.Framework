using Swagger.Assembly.Attributes.CommonlyUsedEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlyUsed.Toolkit;

namespace Swagger.Assembly.Attributes.ExtendedAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ConsumesAttribute : Attribute
    {
        public MIMEType[] Consumes { get; set; }

        public ConsumesAttribute(params MIMEType[] m_Consumes)
        {
            this.Consumes = m_Consumes;
        }

        public override string ToString()
        {
            StringBuilder m_Return = new StringBuilder();

            m_Return.Append("[");
            foreach (var m_Item in Consumes)
            {
                //m_Return.AppendFormat("\"application/{0}\",", m_Item);
                m_Return.AppendFormat("\"{0}\",", m_Item.GetEnumDescription());
            }
            m_Return.Append("]");

            return m_Return.ToString();
        }
    }
}
